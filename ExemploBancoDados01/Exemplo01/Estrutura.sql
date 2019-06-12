DROP TABLE carros;
CREATE TABLE carros (
	id INT PRIMARY KEY IDENTITY(1,1),
	cor VARCHAR(50),
	modelo VARCHAR(80),
	preco DECIMAL(8,2),
	ano INT
);

SELECT * FROM carros;