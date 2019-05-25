-- Scaffold-DbContext -Connection <connection_string> -Provider Microsoft.EntityFrameworkCore.SqlServer -Project RestaurantReviews.Context -Force

CREATE SCHEMA RR;
GO

CREATE TABLE RR.Restaurant
(
	ID INT IDENTITY NOT NULL,
	Name NVARCHAR(128) NOT NULL
)
GO

CREATE TABLE RR.Review
(
	ID INT IDENTITY NOT NULL,
	RestaurantID INT NOT NULL,
	ReviewerName NVARCHAR(128) NOT NULL,
	Score INT NOT NULL,
	Text NVARCHAR(2048) NOT NULL
)
GO

ALTER TABLE RR.Restaurant ADD
	CONSTRAINT PK_Restaurant_ID PRIMARY KEY (ID);
GO

ALTER TABLE RR.Review ADD
	CONSTRAINT PK_Review_ID PRIMARY KEY (ID);
GO

ALTER TABLE RR.Review ADD
	CONSTRAINT FK_Review_Restaurant
		FOREIGN KEY (RestaurantID) REFERENCES RR.Restaurant (ID) ON DELETE CASCADE;
GO
