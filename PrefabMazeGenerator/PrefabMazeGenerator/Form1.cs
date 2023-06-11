using System.Collections;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace PrefabMazeGenerator
{
    public partial class Form1 : Form
    {
        byte[] byteArray = { };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            debugFunc();
        }

        void debugFunc()
        {
            string filePath = @"";
            RadioButton radioBtn = this.Controls.OfType<RadioButton>()
                                       .Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "basic3":
                    filePath = @textBox1.Text;
                    break;

                    case "rotate1":
                    filePath = @textBox2.Text;
                    break;

                    case "rotate2":
                    filePath = @textBox3.Text;
                    break;

                    case "textures":
                    filePath = @textBox4.Text;
                    break;

                    case "textures2":
                    filePath = @textBox5.Text;
                    break;

                    case "traderRekt":
                    filePath = @textBox6.Text;
                    break;

                    default: 
                        break;
                }
            }
            byteArray = File.ReadAllBytes(filePath);
            output.Text +=  BitConverter.ToString(byteArray).Replace("-", "");

            // Move on to building the struct parts
            structParts();
            // end debug func
        }

        void structParts()
        {
            // Continue Reversing the TTS struct.
            // First we will build a rough struct using parts and code to count the bits where we need to.

            int i = 0;
            int baSzie = byteArray.Length;
            //byteArrayIndexPercent.Text = (i / byteArray.Length).ToString();
            byteArrayIndexPercent.Text = i + " / " + baSzie;
            // Header
            byte[] ttsHeader0 = new byte[4] { byteArray[i++], byteArray[i++], byteArray[i++], byteArray[i++] };
            output.Text = "\nHeader: " + BitConverter.ToString(ttsHeader0).Replace("-", "") + " i;" + i.ToString();

            byte[] version = new byte[4] { byteArray[i++], byteArray[i++], byteArray[i++], byteArray[i++] };
            output.Text += "\n Version: " + BitConverter.ToString(version).Replace("-", "") + " i;" + i.ToString();

            byte[] size_xba = new byte[2] { byteArray[i++], byteArray[i++] };
            output.Text += "\n size X: " + BitConverter.ToString(size_xba).Replace("-", "") + " i;" + i.ToString();

            byte[] size_yba = new byte[2] { byteArray[i++], byteArray[i++] };
            output.Text += "\n size Y: " + BitConverter.ToString(size_yba).Replace("-", "") + " i;" + i.ToString();

            byte[] size_zba = new byte[2] { byteArray[i++], byteArray[i++] };
            output.Text += "\n size Y: " + BitConverter.ToString(size_zba).Replace("-", "") + " i;" + i.ToString();

            ushort size_x = BitConverter.ToUInt16(size_xba);
            output.Text += "\n size X: " + size_x.ToString();
            ushort size_y = BitConverter.ToUInt16(size_yba);
            output.Text += "\n size Y: " + size_y.ToString();
            ushort size_z = BitConverter.ToUInt16(size_zba);
            output.Text += "\n size Z: " + size_z.ToString();

            int xyz = size_x * size_y * size_z;
            output.Text += "\n Number of blocks " + xyz + " Number of Blocks BYTES: " + xyz*4;
            //byteArrayIndexPercent.Text = (i / byteArray.Length).ToString();
            byteArrayIndexPercent.Text = i + " / " + baSzie;

            // Layers
            int[] blocksID = new int[xyz];
            byte[] blockDensity = new byte[xyz];
            byte[] blockDamage1 = new byte[xyz];
            byte[] blockDamage2 = new byte[xyz];

            // quick fill
            output.Text += "\n BlockID: ";
            for (int blockIndex = 0; blockIndex < xyz; blockIndex++)
            {
                blocksID[blockIndex] = BitConverter.ToInt32(byteArray, i);
                i += 4;
                //output.Text += blocksID[blockIndex].ToString() + ",";
            }
            //byteArrayIndexPercent.Text = (i / byteArray.Length).ToString();
            byteArrayIndexPercent.Text = i + " / " + baSzie;

            output.Text += "\n BlockDensity: ";
            for (int blockIndex = 0; blockIndex < xyz; blockIndex++)
            {
                blockDensity[blockIndex] = byteArray[i++];
                //output.Text += blockDensity[blockIndex].ToString() + ",";
            }
            //byteArrayIndexPercent.Text = (i / byteArray.Length).ToString();
            byteArrayIndexPercent.Text = i + " / " + baSzie;

            output.Text += "\n Block Damage1: ";
            for (int blockIndex = 0; blockIndex < xyz; blockIndex++)
            {
                blockDamage1[blockIndex] = byteArray[i++];
                //output.Text += blockDamage1[blockIndex].ToString() + ",";
            }
            //byteArrayIndexPercent.Text = (i / byteArray.Length).ToString();
            byteArrayIndexPercent.Text = i + " / " + baSzie;

            output.Text += "\n Block Damage2: ";
            for (int blockIndex = 0; blockIndex < xyz; blockIndex++)
            {
                blockDamage2[blockIndex] = byteArray[i++];
                //output.Text += blockDamage2[blockIndex].ToString() + ",";
            }

            // Textures
            int numberOfBytesTextureFlagbit = BitConverter.ToInt32(byteArray, i);
            i += 4;
            output.Text += "\n Number of Texture bytes: " + numberOfBytesTextureFlagbit.ToString();
            //byteArrayIndexPercent.Text = (i / byteArray.Length).ToString();
            byteArrayIndexPercent.Text = i + " / " + baSzie;

            //convert num bytes of TTS into the Textute bytes[] storing the bits
            output.Text += "\nTexture Byte value: ";
            int[] textureFlagByte = new int[numberOfBytesTextureFlagbit];
            for (int textureByteindex = 0; textureByteindex < numberOfBytesTextureFlagbit; textureByteindex++)
            {
                textureFlagByte[textureByteindex] = byteArray[i++];
                //output.Text += textureFlagByte[textureByteindex] + ",";
            }
            //byteArrayIndexPercent.Text = (i / byteArray.Length).ToString();
            byteArrayIndexPercent.Text = i + " / " + baSzie;

            // Convert
            BitArray textureBitArray = new BitArray(textureFlagByte);
            // Optimal counting method of trues in a bitarray
            int textureCount = (from bool m in textureBitArray
                                where m
                                select m).Count();
            output.Text += "\n Number of blocks with Texture: " + textureCount;

            //
            // Slower bit counting method but indexable
            /*
            bool[] bits = new bool[textureBitArray.Count];
            textureBitArray.CopyTo(bits, 0); 
                                            // textureBitArray can be >= numberOfBytesTextureFlagbit
                                            // This is because the number of blocks used in the prefab may not be a multiple of 8,
                                            // and if so, the last integer has extra zeros at the end.
                                            // We can safely ignore those extra zeros, we dont need to read them
                                            // We also don't need to write them, when converting a bitarray back to an int, it will take care of itself.
            int bitCounter = 0;
            
            for (int bitsIndex = 0; bitsIndex < bits.Count(); bitsIndex++)
            {
                if (bits[bitsIndex])
                {
                    bitCounter++;
                }
            }
            output.Text += "\n Number of blocks with Texture: " + bitCounter;
            */
            //
            //
            output.Text += "\n TextureID: ";
            long[] textures = new long[textureCount];
            for ( int textureIndex = 0; textureIndex < textures.Length; textureIndex++)
            {
                textures[textureIndex] = BitConverter.ToInt64(byteArray, i);
                //output.Text += "\n This block's textures: " + textures[textureIndex] + " Bytes: " + byteArray[i] + "," + byteArray[i+1] + "," + byteArray[i+2] + "," + byteArray[i+3] + "," + byteArray[i+4] + "," + byteArray[i+5] + "," + byteArray[i+6] + "," + byteArray[i+7];
                i += 8;
                //output.Text += textures[textureIndex] + ",";
            }
            //byteArrayIndexPercent.Text = (i / byteArray.Length).ToString();
            byteArrayIndexPercent.Text = i + " / " + baSzie;

            // The next two bytes are zero.

            {
                /*
                // THIS SECTION, IM NOT SURE WHAT DATA IT CONTAINS
                // Same with trigger data. I know the XML stores things like enemies. 
                // Perhaps its related to the trader entity and his placement in the prefab
                // The XML doesn't contain data for the Trader entity. So I think this is for that.
                // The tile entity data count was 5. Im not sure about 5 entities trader rekts prefab.
                // Perhaps otherthings are entities. loot, or something. I think its safe to skip over this for now
                // I can move on to the next step.


                // Tile Entity Data
                short tileEntityCount = BitConverter.ToInt16(byteArray, i);
                i += 2;
                // For each count in tileEntityCount we need to loop and store data,
                if (tileEntityCount > 0)
                {
                    byteArrayIndexPercent.Text = i + " / " + baSzie;
                    output.Text += "\n Tile Entity Count: " + tileEntityCount;
                    for (int tileEntityCountIndex = 0; tileEntityCountIndex < 1; tileEntityCountIndex++)
                    {
                        byteArrayIndexPercent.Text = i + " / " + baSzie;
                        output.Text += "\n Tile Entity Count: " + tileEntityCountIndex;
                        short dataSizeForTile = BitConverter.ToInt16(byteArray, i);
                        i += 2;
                        output.Text += "\n Tile Entity Data size for Tile: " + dataSizeForTile;
                        byte tileEntityType = byteArray[i++];
                        output.Text += "\n Tile Entity Type: " + tileEntityType + "\n Tile Entity Data: ";
                        byte[] tileEntityData = new byte[dataSizeForTile];
                        for (int tileEntityDataIndex = 0; tileEntityDataIndex < tileEntityCount; tileEntityDataIndex++)
                        {
                            tileEntityData[tileEntityDataIndex] = byteArray[i++];
                            output.Text += tileEntityData[tileEntityDataIndex].ToString();
                        }
                    }
                }
                */
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void output_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            output.SelectionStart = output.Text.Length;
            // scroll it automatically
            output.ScrollToCaret();
        }
    }
}