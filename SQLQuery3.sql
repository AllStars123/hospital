use hospital;

GO

SET IDENTITY_INSERT dbo.Pharmacy ON;

GO

CREATE PROCEDURE AddMedicament
(
	@Name VARCHAR(15),
	@Price INT,
	@Quantity INT
)
AS
BEGIN
	DECLARE @MedicamentID INT = (SELECT MAX(MedicamentID)+1 FROM Pharmacy);
	INSERT INTO Pharmacy( Name, Price, Quantity)
		VALUES (@Name, @Price, @Quantity);
END

GO

EXEC AddMedicament 'Pennicillin', 150, 35
GO


SET IDENTITY_INSERT dbo.Doctors ON;
GO

CREATE PROCEDURE HirePerson
(
	@FIO VARCHAR(50),
	@PositionID INT
)
AS
BEGIN
	DECLARE @DoctorID INT = (SELECT MAX(DoctorID)+1 FROM Doctors);
	INSERT INTO Doctors( DoctorID, FIO, PositionID)
		VALUES (@DoctorID, @FIO, @PositionID);
END
GO

EXEC HirePerson 'Ivanov P.P', 2
GO

CREATE PROCEDURE FirePerson
(
	@FIO VARCHAR(50)
)
AS
BEGIN
	DELETE FROM Doctors WHERE FIO=@FIO
END

GO

EXEC FirePerson 'Ivanov P.P'
GO

SET IDENTITY_INSERT dbo.OrderDetails ON;
GO

CREATE PROCEDURE AddMedicamentInOrder
(
	@OrderID INT,
	@MedicamentID INT,
	@Quantity INT
)
AS
BEGIN
	DECLARE @OrderDetailID INT = (SELECT MAX(OrderDetailID)+1 FROM OrderDetails);
	DECLARE @Price INT = (SELECT DISTINCT Pharmacy.Price FROM Pharmacy, OrderDetails WHERE Pharmacy.MedicamentID=@MedicamentID);
	INSERT INTO OrderDetails(OrderDetailID, OrderID,  MedicamentID, Quantity, Price)
		VALUES (@OrderDetailID, @OrderID,  @MedicamentID, @Quantity, @Price);
END
GO

EXEC AddMedicamentInOrder 1, 3, 1
GO

CREATE TRIGGER TriggerAddMedicamentInOrder
ON OrderDetails AFTER INSERT 
AS
BEGIN
	DECLARE @Quantity INT = (SELECT Quantity FROM inserted);
	DECLARE @MedicamentID INT = (SELECT MedicamentID FROM inserted);
	DECLARE @PharmacyQuantity INT = (SELECT Pharmacy.Quantity FROM Pharmacy WHERE Pharmacy.MedicamentID=@MedicamentID);
	UPDATE Pharmacy SET Pharmacy.Quantity=(@PharmacyQuantity-@Quantity);
END
GO

CREATE PROCEDURE DeleteMedicamentFromOrder
(
	@OrderID INT,
	@MedicamentID INT
)
AS
BEGIN
	DELETE FROM OrderDetails WHERE OrderID=@OrderID AND MedicamentID=@MedicamentID;
END
GO

EXEC DeleteMedicamentFromOrder 1, 3
GO
