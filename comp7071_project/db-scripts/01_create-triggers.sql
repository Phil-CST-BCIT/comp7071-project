USE "Comp7071ProjectContext-37fb8ef3-4d95-4ed7-bd7d-9599c2771ffa";
GO

CREATE TRIGGER AfterApplianceINSERT
    ON Appliance
    AFTER INSERT
    AS
BEGIN
    INSERT INTO ApplianceDim
        (Make, Model)
    SELECT
        Make, Model
    FROM inserted;
END;
GO

CREATE TRIGGER AfterAssetINSERT
    ON Asset
    AFTER INSERT
    As
BEGIN
    INSERT INTO AssetDim
        (Type, Status, Location)
    Select
        Type, Status, Location
    FROM inserted;
END;
GO

CREATE TRIGGER AfterRenterINSERT
    ON Renter
    AFTER INSERT
    As
BEGIN
    INSERT INTO RenterDim
        (Name, Income)
    Select
        Name, Income
    FROM inserted;
END;
GO

CREATE TRIGGER AfterMaintenanceRequestINSERT
    ON MaintenanceRequest
    AFTER INSERT
    As
BEGIN
    INSERT INTO MaintenanceRequestDim
        (Description, DateRequested, DateCompleted)
    Select TOP 1
        JobReport.Description,
        inserted.Date,
        JobReport.DateCompleted
    FROM JobReport join inserted
        on JobReport.Id = inserted.Id
    order by JobReport.DateCompleted desc;
END;
GO

CREATE TRIGGER AfterInvoiceINSERT
    ON Invoice
    AFTER INSERT
    As
BEGIN
    -- TODO
    SELECT 1;
END;
GO
