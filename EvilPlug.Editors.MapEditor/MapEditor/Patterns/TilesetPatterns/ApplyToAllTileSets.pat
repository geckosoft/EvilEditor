// ApplyToAllTileSets patterns
BestFriendTileSet=Archives
BestFriendTileSet=Armoury
BestFriendTileSet=Barracks
BestFriendTileSet=ControlRoom
BestFriendTileSet=Corridor
BestFriendTileSet=Dirt
BestFriendTileSet=Freezer
BestFriendTileSet=Infirmary
BestFriendTileSet=InnerSanctum
BestFriendTileSet=Laboratory
BestFriendTileSet=MessHall
BestFriendTileSet=PowerPlant
BestFriendTileSet=StaffRoom
BestFriendTileSet=StrongRoom
BestFriendTileSet=TrainingRoom

BestFriendTileSet=HotelCasino
BestFriendTileSet=HotelLobby
BestFriendTileSet=HotelLounge

BestFriendTileSet=HangarCatwalk


// NORMAL ARCHWAYS ( BORDER BETWEEN TWO DIFFERENT ROOMS )

// --------------------------
// ArchCorner 4 sides, 4 different rooms
// Consists of each of the 4 corners, plus a cap piece.
// There is only one orientation this ever needs to be placed at

// ArchCorner 4 sides cap
FullRotationSymmetry
OverlayPattern=2,2 for 25048-25050
RA/B/F/~O/*,			~RA/~RB/B/F/~O/*
~RA/~RB/B/F/~O/*,	RB/B/F/~O/*

// ArchCorner 4 sides
FullRotationSymmetry
OverlayPattern=2,2 for 25033-25035
RA/B/F/~O/*,		~RA/~RB/B/F/~O
~RA/~RB/B/F/~O,	RB/B/F/~O

// ArchCorner 4 sides, 90
FullRotationSymmetry
OverlayPattern=2,2 for 25030-25032
RA/B/F/~O,			~RA/~RB/B/F/~O/*
~RA/~RB/B/F/~O,	RB/B/F/~O

// ArchCorner 4 sides, 180
FullRotationSymmetry
OverlayPattern=2,2 for 25006-25008
RA/B/F/~O,			~RA/~RB/B/F/~O
~RA/~RB/B/F/~O,	RB/B/F/~O/*

// ArchCorner 4 sides, 270
FullRotationSymmetry
OverlayPattern=2,2 for 25036-25038
RA/B/F/~O,				~RA/~RB/B/F/~O
~RA/~RB/B/F/~O/*,	RB/B/F/~O

// --------------------------
// ArchCorner 4 sides, 2-3 different rooms
// Consists of each of the 4 corners, plus a cap piece.
// There is only one orientation this ever needs to be placed at

// ArchCorner 4 sides cap
FullRotationSymmetry
OverlayPattern=2,2 for 25048-25050
RA/B/F/~O/*,	~RA/B/F/~O/*
~RA/B/F/~O/*,	RA/B/F/~O/*

// ArchCorner 4 sides
FullRotationSymmetry
OverlayPattern=2,2 for 25033-25035
RA/B/F/~O/*,	~RA/B/F/~O
~RA/B/F/~O,		RA/B/F/~O

// ArchCorner 4 sides, 90 degrees
FullRotationSymmetry
OverlayPattern=2,2 for 25030-25032
RA/B/F/~O,		~RA/B/F/~O/*
~RA/B/F/~O,		RA/B/F/~O

// ArchCorner 4 sides, 180 defrees
FullRotationSymmetry
OverlayPattern=2,2 for 25006-25008
RA/B/F/~O,		~RA/B/F/~O
~RA/B/F/~O,		RA/B/F/~O/*

// ArchCorner 4 sides, 270 degrees
FullRotationSymmetry
OverlayPattern=2,2 for 25036-25038
RA/B/F/~O,		~RA/B/F/~O
~RA/B/F/~O/*,	RA/B/F/~O

// --------------------------
// ArchCorner 3 sides
// Each uses 2 of the "4sides corner pieces" plus the "3sides straight egde and cap" model
// All 4 orientations are needed for this case

// ArchCorner 3 sides, straight edge and cap
FullRotationSymmetry
OverlayPattern=2,2 for 25042-25044
RB/B/F/~O/*,	RB/B/F/~O/*
RA/B/F/~O,		~RA/~RB/B/F/~O

// ArchCorner 3 sides, corner piece 1
FullRotationSymmetry
OverlayPattern=2,2 for 25006-25008
RB/B/F/~O,	RB/B/F/~O
RA/B/F/~O,	~RA/~RB/B/F/~O/*

// ArchCorner 3 sides, corner piece 2
FullRotationSymmetry
OverlayPattern=2,2 for 25036-25038
RB/B/F/~O,			RB/B/F/~O
RA/B/F/~O/*,		~RA/~RB/B/F/~O

// ArchCorner 3 sides, 90, straight edge and cap
FullRotationSymmetry
OverlayPattern=2,2 for 25039-25041
~RA/~RB/B/F/~O,	RB/B/F/~O/*
RA/B/F/~O,			RB/B/F/~O/*

// ArchCorner 3 sides, 90, corner piece 1
FullRotationSymmetry
OverlayPattern=2,2 for 25033-25035
~RA/~RB/B/F/~O/*, RB/B/F/~O
RA/B/F/~O,				RB/B/F/~O

// ArchCorner 3 sides, 90, corner piece 2
FullRotationSymmetry
OverlayPattern=2,2 for 25036-25038
~RA/~RB/B/F/~O,	RB/B/F/~O
RA/B/F/~O/*,		RB/B/F/~O

// ArchCorner 3 sides, 180, straight edge and cap
FullRotationSymmetry
OverlayPattern=2,2 for 25003-25005
~RA/~RB/B/F/~O, RA/B/F/~O
RB/B/F/~O/*,		RB/B/F/~O/*

// ArchCorner 3 sides, 180, corner piece 1
FullRotationSymmetry
OverlayPattern=2,2 for 25033-25035
~RA/~RB/B/F/~O/*,	RA/B/F/~O
RB/B/F/~O,				RB/B/F/~O

// ArchCorner 3 sides, 180, corner piece 2
FullRotationSymmetry
OverlayPattern=2,2 for 25030-25032
~RA/~RB/B/F/~O,	RA/B/F/~O/*
RB/B/F/~O,			RB/B/F/~O

// ArchCorner 3 sides, 270, straight edge and cap
FullRotationSymmetry
OverlayPattern=2,2 for 25045-25047
RB/B/F/~O/*,	RA/B/F/~O
RB/B/F/~O/*,	~RA/~RB/B/F/~O

// ArchCorner 3 sides, 270, corner piece 1
FullRotationSymmetry
OverlayPattern=2,2 for 25030-25032
RB/B/F/~O, 	RA/B/F/~O/*
RB/B/F/~O,	~RA/~RB/B/F/~O

// ArchCorner 3 sides, 270, corner piece 2
FullRotationSymmetry
OverlayPattern=2,2 for 25006-25008
RB/B/F/~O,		 	RA/B/F/~O
RB/B/F/~O,			~RA/~RB/B/F/~O/*

// --------------------------
// There are unique models for each orientation

// ArchCorner 2 sides
FullRotationSymmetry
OverlayPattern=2,2 for 25000-25002
B/F/RB/~O/*,	B/F/RB/~O/*
B/F/RB/~O/*,	B/F/RA/~O/*

// ArchCorner 2 sides 90
FullRotationSymmetry
OverlayPattern=2,2 for 25021-25023
B/F/RB/~O/*,	B/F/RA/~O/*
B/F/RB/~O/*,	B/F/RB/~O/*

// ArchCorner 2 sides 180
FullRotationSymmetry
OverlayPattern=2,2 for 25024-25026
B/F/RA/~O/*,	B/F/RB/~O/*
B/F/RB/~O/*,	B/F/RB/~O/*

// ArchCorner 2 sides 270
FullRotationSymmetry
OverlayPattern=2,2 for 25027-25029
B/F/RB/~O/*,	B/F/RB/~O/*
B/F/RA/~O/*,	B/F/RB/~O/*

// --------------------------
// just simple cases left...

// ArchCentral
LimitedRotationSymmetry
OverlayPattern=2,2 for 25012-25014
B/F/RA/~O/*,	B/F/RA/~O/*
B/F/RB/~O/*,	B/F/RB/~O/*

// ArchCentral
LimitedRotationSymmetry
OverlayPattern=2,2 for 25012-25014
B/F/RB/~O/*,	B/F/RB/~O/*
B/F/RA/~O/*,	B/F/RA/~O/*

// ArchEnd Left
LimitedRotationSymmetry
OverlayPattern=2,2 for 25015-25017
~F,	B/F/RA/~O/*
?,	B/F/~RA/~O/*

// ArchEnd Left
LimitedRotationSymmetry
OverlayPattern=2,2 for 25015-25017
?,	B/F/~RA/~O/*
~F,	B/F/RA/~O/*

// ArchEnd Right
LimitedRotationSymmetry
OverlayPattern=2,2 for 25018-25020
B/F/RA/~O/*, ~F
B/F/~RA/~O/*, ?

// ArchEnd Right
LimitedRotationSymmetry
OverlayPattern=2,2 for 25018-25020
B/F/~RA/~O/*, ?
B/F/RA/~O/*, ~F

// NORMAL ARCHWAYS BORDERING BLUEPRINT ROOMS
// (~F on adjacent square replaced by ~B)

// ArchEnd Left
LimitedRotationSymmetry
OverlayPattern=2,2 for 25015-25017
~B/~O,	B/F/RA/~O/*
?/~O,	B/F/~RA/~O/*

// ArchEnd Left
LimitedRotationSymmetry
OverlayPattern=2,2 for 25015-25017
?/~O,	B/F/~RA/~O/*
~B/~O,	B/F/RA/~O/*

// ArchEnd Right
LimitedRotationSymmetry
OverlayPattern=2,2 for 25018-25020
B/F/RA/~O/*, ~B/~O
B/F/~RA/~O/*, ?/~O

// ArchEnd Right
LimitedRotationSymmetry
OverlayPattern=2,2 for 25018-25020
B/F/~RA/~O/*, ?/~O
B/F/RA/~O/*, ~B/~O

// BLUEPRINT ARCHWAYS ( BORDER BETWEEN AN UNBUILT ROOM AND A BUILT ROOM )

// Blueprint ArchCentral
OverlayPattern=2,2 for 25065-25067
~B/F/RA,	~B/F/*/RA
~RA/F,		B/~RA/F

// Blueprint ArchEnd Left
OverlayPattern=2,2 for 25053-25055
~B/~RA,	~B/F/*/RA
F,		B/F/~RA

// Blueprint ArchEnd Left
OverlayPattern=2,2 for 25053-25055
F,		~B/F/*/RA
~B/~RA,	B/F/~RA

// Blueprint ArchEnd Left
OverlayPattern=2,2 for 25053-25055
~F,	~B/F/*/RA
F,	B/F/~RA

// Blueprint ArchEnd Left
OverlayPattern=2,2 for 25053-25055
F,	~B/F/*/RA
~F,	B/F/~RA

// Blueprint ArchEnd Left
OverlayPattern=2,2 for 25053-25055
~F,	~B/F/*/RA
~F,	B/F/~RA

// Blueprint ArchEnd Right
OverlayPattern=2,2 for 25056-25058
~B/F/*/RA,	~B/~RA
B/F/~RA,	F

// Blueprint ArchEnd Right
OverlayPattern=2,2 for 25056-25058
~B/F/*/RA,	F
B/F/~RA,	~B/~RA

// Blueprint ArchEnd Right
OverlayPattern=2,2 for 25056-25058
~B/F/*/RA,	~F
B/F/~RA,	F

// Blueprint ArchEnd Right
OverlayPattern=2,2 for 25056-25058
~B/F/*/RA,	F
B/F/~RA,	~F

// Blueprint ArchEnd Right
OverlayPattern=2,2 for 25056-25058
~B/F/*/RA,	~F
B/F/~RA,	~F

// Blueprint ArchCornerIn
OverlayPattern=2,2 for 25062-25064
~RA/F,	~B/F/RA/*
?,		B/~RA/F

// Blueprint ArchCornerOut
OverlayPattern=2,2 for 25059-25061
~B/F/RA,	~RA/F
~B/F/RA/*, ~B/RA/F

// BLUEPRINT ARCHWAYS ( BORDER BETWEEN AN UNBUILT ROOM AND ANOTHER UNBUILT ROOM )

// Blueprint ArchCentral
LimitedRotationSymmetry
OverlayPattern=2,2 for 25065-25067
~B/F/RA/~O,	~B/F/*/RA/~O
~RA/F,		~B/~RA/F

// Blueprint ArchEnd Left
LimitedRotationSymmetry
OverlayPattern=2,2 for 25053-25055
~B/~RA/~O,	~B/F/*/RA/~O
F/~O,		~B/F/~RA/~O

// Blueprint ArchEnd Left
LimitedRotationSymmetry
OverlayPattern=2,2 for 25053-25055
~F,	~B/F/*/RA/~O
F,	~B/F/~RA/~O

// Blueprint ArchEnd Left
LimitedRotationSymmetry
OverlayPattern=2,2 for 25053-25055
F,	~B/F/*/RA/~O
~F,	~B/F/~RA/~O

// Blueprint ArchEnd Left
LimitedRotationSymmetry
OverlayPattern=2,2 for 25053-25055
~F,	~B/F/*/RA/~O
~F,	~B/F/~RA/~O

// Blueprint ArchEnd Right
LimitedRotationSymmetry
OverlayPattern=2,2 for 25056-25058
~B/F/*/RA/~O,	~B/~RA/~O
~B/F/~RA/~O,	F/~O

// Blueprint ArchEnd Right
LimitedRotationSymmetry
OverlayPattern=2,2 for 25056-25058
~B/F/*/RA/~O,	~F
~B/F/~RA/~O,	F

// Blueprint ArchEnd Right
LimitedRotationSymmetry
OverlayPattern=2,2 for 25056-25058
~B/F/*/RA/~O,	F
~B/F/~RA/~O,	~F

// Blueprint ArchEnd Right
LimitedRotationSymmetry
OverlayPattern=2,2 for 25056-25058
~B/F/*/RA/~O,	~F
~B/F/~RA/~O,	~F

// Blueprint ArchCornerIn
LimitedRotationSymmetry
OverlayPattern=2,2 for 25062-25064
~RA/F/~O,	~B/F/RA/*/~O
?,			~B/~RA/F/~O

// Blueprint ArchCornerOut
LimitedRotationSymmetry
OverlayPattern=2,2 for 25059-25061
~B/F/RA/~O,		~RA/F/~O
~B/F/RA/*/~O, ~B/RA/F/~O

EndList