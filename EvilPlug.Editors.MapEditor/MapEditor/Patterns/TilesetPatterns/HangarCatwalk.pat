// Hangar Catwalk tileset

// This tileset can only be built on the specified tilesets
FriendTileSet=HangarEmptySpace
FriendTileSet=RocketCaveWalls
FriendTileSet=Global_Custom_CaveRocket_44X60_Developed_A


// 4-sided wall
FullRotationSymmetry
TilePattern=3,3 for 26605
?,	~F,		?
~F,	F/*,	~F
?,	~F,		?

// 3-sided wall
TilePattern=3,3 for 26604
?,	F,		?
~F,	F/*,	~F
?,	~F,		?

// 2-sided wall
TilePattern=3,3 for 26602
?,	F,		?
F,	F/*,	~F
?,	~F,		?

// 2-sided wall, one side not built
TilePattern=3,3 for 26602
?,	F,		?
F,	B/F/*,	~B
?,	~F,		?

// 2-sided wall, other side not built
TilePattern=3,3 for 26602
?,	F,		?
F,	B/F/*,	~F
?,	~B,		?

// 2-sided wall, both sides not built
TilePattern=3,3 for 26602
?,	F,		?
F,	B/F/*,	~B
?,	~B,		?

// 2-sided wall (opposite)
TilePattern=1,3 for 26603
~F
F/*
~F

// 1-sided wall
TilePattern=1,2 for 26601
F/*
~F

// 1-sided wall, side not built
TilePattern=1,2 for 26601
B/F/*
~B

// Empty floor space
FullRotationSymmetry
TilePattern=1,1 for 26600
F/*

// CornerOut piece, built
OverlayPattern=2,2 for 26606
F/B/*,	F/B
F/B,		I

// CornerOut piece, not built
OverlayPattern=2,2 for 26606
F/~B/*,	F/~B
F/~B,	~F

// CornerOut piece, beside not built square
OverlayPattern=2,2 for 26606
F/B/*,	F/B
F/B,	~B

// CAVE WALL STUFF (when building a catwalk up to unmined dirt)

// Cavern Wall plug
DefineTileSetA=HangarCatwalk
DefineTileSetB=UnminedDirt
OverlayPattern=1,2 for 26407
TB
TA/*

// MISSING CORNER OUT (because the catwalk doesn't have walls to cover the joins)

// CornerOut piece
DefineTileSetA=HangarCatwalk
DefineTileSetB=UnminedDirt
OverlayPattern=2,2 for 26610-26612
TA/*,		TA
TA,			TB

EndList