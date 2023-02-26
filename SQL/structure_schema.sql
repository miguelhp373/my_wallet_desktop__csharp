CREATE	DATABASE	PROD_MY_WALLET_APPLICATION
GO
USE	PROD_MY_WALLET_APPLICATION
GO
CREATE	TABLE	PROD_USERS_TABLE
(
userId		INTEGER		NOT NULL	IDENTITY	PRIMARY	KEY	,	
userName	VARCHAR(100)	NULL						,
userPass	VARBINARY(32)	NOT NULL					,
userADM		VARCHAR(005)	NOT NULL	DEFAULT('FALSE')		,
userActive	VARCHAR(005)	NOT NULL	DEFAULT('FALSE')		
)
GO
SELECT * FROM PROD_USERS_TABLE
