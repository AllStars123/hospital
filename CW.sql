use hospital;

--информация о болезнях пациентов
SELECT FIO, name FROM patients INNER JOIN PatientsDiagnos ON
patients.PatientID=PatientsDiagnos.PatientID INNER JOIN Diagnos ON
PatientsDiagnos.DiagnosID=Diagnos.DiagnosID

--просмотр информации о врачах
SELECT FIO, Phone, Position, Salary FROM Doctors, DoctorsPositions WHERE Doctors.PositionID=DoctorsPositions.PositionID ORDER BY Salary ASC

--просмотр всех заказов от пациентов
Select Orders.OrderID, Name FROM Orders INNER JOIN OrderDetails ON 
Orders.OrderID=OrderDetails.OrderID INNER JOIN Pharmacy ON
OrderDetails.MedicamentID=Pharmacy.MedicamentID

--процедуры, которые не назначены ни одному пациенту
SELECT procedurs.name FROM procedurs
EXCEPT (
SELECT procedurs.name FROM patients
LEFT JOIN vizit ON patients.PatientID = vizit.PatientID
LEFT JOIN PatientsProcedurs on PatientsProcedurs.VisitID = vizit.VisitID
LEFT JOIN procedurs ON procedurs.ProcedureID=PatientsProcedurs.ProcedureID
GROUP BY procedurs.name
)

--просмотр ходовых товаров
SELECT DISTINCT MedicamentID FROM OrderDetails
 UNION 
SELECT DISTINCT MedicamentID FROM Pharmacy

-- пациенты, которые не могут заплатить за назначенную процедуру
SELECT patients.FIO FROM patients
LEFT JOIN vizit ON vizit.PatientID=patients.PatientID
JOIN PatientsProcedurs ON PatientsProcedurs.VisitID = vizit.VisitID
LEFT JOIN procedurs ON procedurs.ProcedureID=PatientsProcedurs.ProcedureID
WHERE (patients.account < procedurs.price)
group by patients.FIO

--просмотр количества приемов у определенного доктора на определенную дату
SELECT COUNT(*) FROM vizit, Doctors WHERE vizit.DoctorID=Doctors.DoctorID AND FIO='Andreev' AND Date='2020-12-05'

--просмотр лекарств, которые не покупают 
SELECT Pharmacy.MedicamentID, Name FROM Pharmacy LEFT JOIN OrderDetails ON 
Pharmacy.MedicamentID=OrderDetails.MedicamentID WHERE OrderDetails.MedicamentID IS NULL

--узнать информацию о пациентах, которые записаны на прием в определенную дату
SELECT FIO, polis, passport FROM vizit, patients WHERE vizit.PatientID=patients.PatientID AND Date='2020-12-05'

--доктора, которые никого не лечат
SELECT Doctors.FIO FROM Doctors
EXCEPT (
SELECT Doctors.FIO FROM Doctors
JOIN vizit ON Doctors.DoctorID = vizit.DoctorID
JOIN patients on patients.PatientID = vizit.PatientID
JOIN PatientsDiagnos ON patients.PatientID = PatientsDiagnos.PatientID
JOIN StatusDiagnos ON PatientsDiagnos.StatusID = StatusDiagnos.StatusID
GROUP BY Doctors.FIO )

--узнать на какие лекарства цена больше 100 и меньше 1000
SELECT Name FROM Pharmacy WHERE Price BETWEEN 100 AND 1000

--доктора, которые назначили и процедуру и диагноз за один визит
SELECT Doctors.FIO FROM Doctors
JOIN vizit ON Doctors.DoctorID = vizit.DoctorID
JOIN patients ON patients.PatientID = vizit.PatientID
JOIN PatientsDiagnos ON patients.PatientID = PatientsDiagnos.PatientID
GROUP BY Doctors.FIO
INTERSECT
SELECT Doctors.FIO FROM Doctors
JOIN vizit ON Doctors.DoctorID = vizit.DoctorID
JOIN PatientsProcedurs ON PatientsProcedurs.VisitID = vizit.VisitID
GROUP BY Doctors.FIO

--имена пациентов, которым поставили диагноз
SELECT FIO FROM patients, PatientsDiagnos WHERE patients.PatientID IN (SELECT PatientID FROM StatusDiagnos, PatientsDiagnos WHERE StatusDiagnos.StatusID=PatientsDiagnos.StatusID
AND name='made') AND patients.PatientID=PatientsDiagnos.PatientID

--диагнозы, которыми не болеют
SELECT DiagnosID FROM Diagnos EXCEPT
SELECT DiagnosID FROM PatientsDiagnos