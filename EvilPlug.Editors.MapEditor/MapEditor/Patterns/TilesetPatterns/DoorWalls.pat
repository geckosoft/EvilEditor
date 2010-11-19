// Check this tileset whenever BestFriends are nearby
BestFriendTileSet=[Door TileSet]

// Door 'Half' Wall
DefineTileSetA=[Door TileSet]
OverlayPattern=2,2 for [Door Wall L]
~F,		~D
~F/~D,	F/TA/*

// Door 'Half' Wall R (Reversed)
DefineTileSetA=[Door TileSet]
OverlayPattern=2,2 for [Door Wall R]
~D,		~F
F/TA/*,	~F/~D

// Door 'Half' Wall CornerOut L
DefineTileSetA=[Door TileSet]
OverlayPattern=2,2 for [Door Wall CornerOut L]
F,		F/~D
~F/~D,	F/TA/*

// Door 'Half' Wall CornerOut R
DefineTileSetA=[Door TileSet]
OverlayPattern=2,2 for [Door Wall CornerOut R]
F/~D,	F
F/TA/*,	~F/~D

EndList