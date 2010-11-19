// Cave walls template

// Check this tileset whenever BestFriends are nearby
BestFriendTileSet=[Cave TileSet]

// Wall 1 side
DefineTileSetA=[Cave Wall TileSet]
DefineTileSetB=UnminedDirt
TilePattern=1,2 for [Wall 1 Side]
TB
TA/I/*

// Wall 1 side
DefineTileSetA=[Cave Wall TileSet]
DefineTileSetB=HangarEmptySpace
TilePattern=1,3 for [Wall 1 Side]
~TA
TA/I/*
TB

// Wall 1 side
DefineTileSetA=[Cave Wall TileSet]
DefineTileSetB=HangarSolidSpace
TilePattern=1,3 for [Wall 1 Side]
~TA
TA/I/*
TB

// Wall 1 side
DefineTileSetA=[Cave Wall TileSet]
DefineTileSetB=HangarCatwalk
TilePattern=1,3 for [Wall 1 Side]
~TA
TA/I/*
TB

// Floor (purely for level design mode)
TilePattern=1,1 for [Floor]
I/*

// Door in wall (e.g. Hangar Lift Door)
DefineTileSetA=[Cave TileSet]
DefineTileSetB=HangarCatwalk
LimitedRotationSymmetry
OverlayPattern=2,4 for [Door In Wall]
?,		TA/~F
~TA,	~TA/~TB/F/B/*
~TA,	~TA/~TB/F
?,		TA/~F

// Door in wall (e.g. Hangar Lift Door)
DefineTileSetA=[Cave TileSet]
DefineTileSetB=HangarCatwalk
LimitedRotationSymmetry
OverlayPattern=2,4 for [Door In Wall Ghost]
?,		TA/~F
~TA,	~TA/~TB/F/~B/*
~TA,	~TA/~TB
?,		TA/~F

EndList
