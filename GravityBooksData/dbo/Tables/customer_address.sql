CREATE TABLE customer_address (
    customer_id INT,
    address_id INT,
    status_id INT,
    CONSTRAINT pk_custaddr PRIMARY KEY (customer_id, address_id),
    CONSTRAINT fk_ca_cust FOREIGN KEY (customer_id) REFERENCES customer (customer_id),
    CONSTRAINT fk_ca_addr FOREIGN KEY (address_id) REFERENCES address (address_id)
);