CREATE TABLE [dbo].[MembershipTypes] (
    [Id]               TINYINT  NOT NULL,
    [SignUpFee]        SMALLINT NOT NULL,
    [DurationInMonths] TINYINT  NOT NULL,
    [MemberShipType]   VARCHAR(244)  DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_dbo.MembershipTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

