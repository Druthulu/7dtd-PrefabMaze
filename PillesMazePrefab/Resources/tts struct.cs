// Header
{
    ansi tts[3];
    byte blank;
    uint32 Version; // Version
    ushort size_x, size_y, size_z;
} Header;

// Layers
{
    {
        {
            int32 xBlock_id[Header.size_x];
        } yBlockId[Header.size_y];
    } zBlockId[Header.size_z];
} xyzBlockIds;

// Block Density
{
    {
        {
            byte xBlock_density_value[Header.size_x];
        } yBlockDensity[Header.size_y];
    } zBlockDensity[Header.size_z];
} xyzBlockDensity;

// Block Damage - 0 no damage - Shouldn't need to seperate xyz here
{
    byte blockDamageValue[Header.size_z*Header.size_y*Header.size_x];
    byte blockDamageValue[Header.size_z*Header.size_y*Header.size_x];
} xyzBlockDamage;

// Texture data
{
    int32 numberOfBytesTextureFlag;
    bin data[numberOfBytesTextureFlag];
} TextureFlags;

//Code
// need to count bits in the bitstream
while n;
    n &= (n-1)
    result += 1;
return result;
//Code

// Im not sure if I can have code inside the struct, 
// I could track my index, and build each piece of the struct at a time, 
// and then put it together into the final struct.

{
    long texture[blocksWithTextureCount]//4 bytes ints actually 8
} TextureId[6*each 1 in the bin data];

// I don't think its a long, I think its 6 bytes, 1 bytes per face
// 6 bytes for each 1 in the last bin
// 6 bytes order are something like: top,bottom, then horizontal faces
// two bytes inbetween each texture data
// I think its more like 8 bytes, 



// Tile entity data, I think this is things like Trader, chickens etc. reading
short tileEntityCount;
{
    short dataSizeForTile;
    byte titleEntityType;
    byte data[dataSizeForTile];
} TileEntityData[tileEntityCount];

// Trigger data, Not sure what this
short triggerCount;
{
    short dataSizeForTrigger;
    int32 position[3]; //Vector3i
    byte data[dataSizeForTrigger]
} TriggerData[triggerCount];



// Tile Entity data
// I think this is for sleepers? Not sure
// no sleeper volumes are stored in the xml file

// Header
{
{ ansi x0, x1, x2; } tts[3]
byte blank;
} Header;

































// Header

{
    {
        ansi tts[3];
    };
    byte blank;
} Header;


// Version
uint32 Version;

// Prefab Sizes
ushort size_x, size_y, size_z;

// Layers
{
    {
        {
            int32 block_id;
        } xBlockId[size_x];
    } yBlockId[size_y];
} zBlockId[size_z];

// Block Density
{
    {
        {
            byte block_density_value;
        } xBlockDensity[size_x];
    } yBlockDensity[size_y];
} zBlockDensity[size_z];

// Block Damage - 0 no damage - Shouldn't need to seperate xyz here
{
    byte blockDamageValue;
} xyzBlockDamage1[size_z*size_y*size_x];
{
    byte blockDamageValue;
} xyzBlockDamage2[size_z*size_y*size_x];


// Texture data
int32 numberOfBytesTextureFlag;
{
    bin data;
} TextureFlag[numberOfBytesTextureFlag];


// I don't think its a long, I think its 6 bytes, 1 bytes per face
// 6 bytes for each 1 in the last bin
// 6 bytes order are something like: top,bottom, then horizontal faces
{
    long 
} TextureId[6*each 1 in the bin data];

// two bytes inbetween each texture data
// I think its more like 8 bytes, 



// End of the file is two empty bytes
byte end1, end2;




// Tile Entity data
// I think this is for sleepers? Not sure
// no sleeper volumes are stored in the xml file

// Header
{
{ ansi x0, x1, x2; } tts[3]
byte blank;
} Header;









/*
// Block Damage - 0 no damage
{
    {
        {
            byte block_Damage_Data
        } xBlockDamage[size_x];
    } yBlockDamage[size_y];
} zBlockDamage[size_z];
*/