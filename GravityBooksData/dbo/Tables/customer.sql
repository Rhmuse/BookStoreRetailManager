CREATE TABLE customer (
    customer_id INT,
    first_name VARCHAR(200),
    last_name VARCHAR(200),
    email VARCHAR(350),
    CONSTRAINT pk_customer PRIMARY KEY (customer_id)
);