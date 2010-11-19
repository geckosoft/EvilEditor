// Standard tileset template

// Empty floor space, 4x4
FullRotationSymmetry
TilePattern=4,4 for [Floor 4x4]
B/F/*,	B/F/*,	B/F/*,	B/F/*
B/F/*,	B/F/*,	B/F/*,	B/F/*
B/F/*,	B/F/*,	B/F/*,	B/F/*
B/F/*,	B/F/*,	B/F/*,	B/F/*

// Empty floor space, 4x3
TilePattern=4,3 for [Floor 4x3]
B/F/*,	B/F/*,	B/F/*,	B/F/*
B/F/*,	B/F/*,	B/F/*,	B/F/*
B/F/*,	B/F/*,	B/F/*,	B/F/*

// Empty floor space, 3x3
FullRotationSymmetry
TilePattern=3,3 for [Floor 3x3]
B/F/*,	B/F/*,	B/F/*
B/F/*,	B/F/*,	B/F/*
B/F/*,	B/F/*,	B/F/*

// Empty floor space, 4x2
TilePattern=4,2 for [Floor 4x2]
B/F/*,	B/F/*,	B/F/*,	B/F/*
B/F/*,	B/F/*,	B/F/*,	B/F/*

// Empty floor space, 3x2
TilePattern=3,2 for [Floor 3x2]
B/F/*,	B/F/*,	B/F/*
B/F/*,	B/F/*,	B/F/*

// Empty floor space, 2x2
FullRotationSymmetry
TilePattern=2,2 for [Floor 2x2]
B/F/*,	B/F/*
B/F/*,	B/F/*

// Empty floor space, 2x2 L shape
TilePattern=2,2 for [Floor 2x2 L-shape]
B/F/*,	B/F/*
B/F/*,	~I

// Empty floor space, 4x1
TilePattern=4,1 for [Floor 4x1]
B/F/*,	B/F/*,	B/F/*,	B/F/*

// Empty floor space, 3x1
TilePattern=3,1 for [Floor 3x1]
B/F/*,	B/F/*,	B/F/*

// Empty floor space, 2x1
TilePattern=2,1 for [Floor 2x1]
B/F/*,	B/F/*

// Empty floor space
FullRotationSymmetry
TilePattern=1,1 for [Floor]
F/*

// Wall 1 side (x8)
IsWallOverlay
ConstructedFrom [Wall 1 Side]
OverlayPattern=10,2 for [Wall 1 Side x8]
F,	B/F/*,	B/F/*,	B/F/*,	B/F/*,	B/F/*,	B/F/*,	B/F/*,	B/F/*,	F
~F,	I,		I,		I,		I,		I,		I,		I,		I,		~F

// Wall 1 side (x4)
IsWallOverlay
ConstructedFrom [Wall 1 Side]
OverlayPattern=6,2 for [Wall 1 Side x4]
F,	B/F/*,	B/F/*,	B/F/*,	B/F/*,	F
~F,	I,		I,		I,		I,		~F

// Wall 1 side (x3)
IsWallOverlay
ConstructedFrom [Wall 1 Side]
OverlayPattern=5,2 for [Wall 1 Side x3]
F,	B/F/*,	B/F/*,	B/F/*,	F
~F,	I,		I,		I,		~F

// Wall 1 side (x2)
IsWallOverlay
ConstructedFrom [Wall 1 Side]
OverlayPattern=4,2 for [Wall 1 Side x2]
F,	B/F/*,	B/F/*,	F
~F,	I,		I,		~F

// Wall 1 side
IsWallOverlay
OverlayPattern=3,2 for [Wall 1 Side]
F,	F/*,	F
~F,	I,		~F

// Wall CornerIn L
IsWallOverlay
OverlayPattern=3,2 for [Wall CornerIn L]
~F,	F/*,	F
?,	I,		~F

// Wall CornerIn R
IsWallOverlay
OverlayPattern=3,2 for [Wall CornerIn R]
F,	F/*,	~F
~F,	I,		?

// Wall CornerIn Both
IsWallOverlay
OverlayPattern=3,2 for [Wall CornerIn Both]
~F,	F/*,	~F
?,	I,		?

// Wall CornerOut L
IsWallOverlay
OverlayPattern=3,2 for [Wall CornerOut L]
F,	F/*,	F
F,	I,		~F

// Wall CornerOut R
IsWallOverlay
OverlayPattern=3,2 for [Wall CornerOut R]
F,	F/*,	F
~F,	I,		F

// Wall CornerOut Both
IsWallOverlay
OverlayPattern=3,2 for [Wall CornerOut Both]
F,	F/*,	F
F,	I,		F

// Wall CornerOut L CornerIn R
IsWallOverlay
OverlayPattern=3,2 for [Wall CornerOut L CornerIn R]
F,	F/*,	~F
F,	I,		?

// Wall CornerOut R CornerIn L
IsWallOverlay
OverlayPattern=3,2 for [Wall CornerOut R CornerIn L]
~F,	F/*,	F
?,	I,		F

// Wall Plug
OverlayPattern=2,2 for [Wall Plug]
F/*,	I
I,		I