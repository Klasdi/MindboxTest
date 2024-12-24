CREATE TABLE Product (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100)
);

CREATE TABLE Category (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(100)
);

CREATE TABLE Product_category (
    product_id INT,
    category_id INT,
    PRIMARY KEY (product_id, category_id),
    FOREIGN KEY (product_id) REFERENCES Product(product_id),
    FOREIGN KEY (category_id) REFERENCES Category(category_id)
);

INSERT INTO Product (product_id, product_name) VALUES (1, '������');
INSERT INTO Product (product_id, product_name) VALUES (2, 'Nike');
INSERT INTO Product (product_id, product_name) VALUES (3, '������');
INSERT INTO Product (product_id, product_name) VALUES (4, '�����');

INSERT INTO Category (category_id, category_name) VALUES (1, '�������� ����');
INSERT INTO Category (category_id, category_name) VALUES (2, 'Ҹ���� ����');
INSERT INTO Category (category_id, category_name) VALUES (3, '���������');

INSERT INTO Product_category (product_id, category_id) VALUES (1, 2);
INSERT INTO Product_category (product_id, category_id) VALUES (2, 3);
INSERT INTO Product_category (product_id, category_id) VALUES (3, 1);
INSERT INTO Product_category (product_id, category_id) VALUES (3, 2);

SELECT p.product_name AS '�������', COALESCE(c.category_name, '��� ���������') AS '���������'
FROM Product p LEFT JOIN Product_category pc ON p.product_id = pc.product_id
LEFT JOIN Category c ON pc.category_id = c.category_id;