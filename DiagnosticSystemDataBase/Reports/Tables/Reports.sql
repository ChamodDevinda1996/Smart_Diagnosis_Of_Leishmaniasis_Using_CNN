CREATE TABLE [Reports].[Reports] (
    [ReportId]    BIGINT          IDENTITY (1, 1) NOT NULL,
    [UserId]      VARCHAR (128)   NOT NULL,
    [CreatedDate] DATETIME2 (7)   NOT NULL,
    [Result]      VARBINARY (MAX) NOT NULL,
    CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED ([ReportId] ASC)
);

