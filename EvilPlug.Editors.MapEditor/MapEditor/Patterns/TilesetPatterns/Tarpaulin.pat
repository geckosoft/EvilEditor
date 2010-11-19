// Tarpaulin tileset
IsTileSetIndifferent

// Can be used anywhere
IsIndoorTileSet
IsOutdoorTileSet

// 4-sided wall
FullRotationSymmetry
OverlayPattern=3,3 for 24515-24517
?,		~TARP,	?
~TARP,	TARP/*,	~TARP
?,		~TARP,	?

// 3-sided wall
OverlayPattern=3,3 for 24512-24514
?,		TARP,	?
~TARP,	TARP/*,	~TARP
?,		~TARP,	?

// 2-sided wall
OverlayPattern=3,3 for 24503-24505
?,		TARP,			?
TARP,	TARP/*,		~TARP
?,		~TARP,		?

// 2-sided wall (opposite)
OverlayPattern=3,3 for 24509-24511
?,		~TARP,			?
TARP,	TARP/*,		TARP
?,		~TARP,		?

// 1-sided wall
OverlayPattern=3,3 for 24500-24502
?,		TARP,		?
TARP,	TARP/*,		TARP
?,		~TARP,		?

// Tarpaulin Square
FullRotationSymmetry
OverlayPattern=3,3 for 24506-24508
?,		TARP,			?
TARP,	TARP/*,		TARP
?,		TARP,			?

EndList