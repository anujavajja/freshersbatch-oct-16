SELECT *  FROM Customer
SELECT * FROM OrderTable
SELECT * FROM OrderItem

SELECT * FROM Customer WHERE Country LIKE'[AI]%'
SELECT * FROM Customer WHERE FirstName LIKE '__I%'
SELECT * FROM Customer WHERE Country = 'GERMANY'
SELECT FirstName + ' ' + LastName as Fullname from Customer
SELECT * FROM Customer WHERE LastName LIKE '_U%'
