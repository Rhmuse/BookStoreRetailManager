CREATE TABLE shipping_method (
    method_id INT,
    method_name VARCHAR(100),
    cost DECIMAL(6, 2),
    CONSTRAINT pk_shipmethod PRIMARY KEY (method_id)
);