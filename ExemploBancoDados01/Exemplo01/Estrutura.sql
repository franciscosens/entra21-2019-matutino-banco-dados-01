﻿CREATE TABLE carros (
	id INT PRIMARY KEY IDENTITY(1,1),
	cor VARCHAR(50),
	modelo VARCHAR(80),
	preco DECIMAL(6,2),
	ano INT
);