CREATE TABLE cust_order (
    order_id INT IDENTITY,
    order_date DATETIME,
    customer_id INT,
    shipping_method_id INT,
    dest_address_id INT,
    CONSTRAINT pk_custorder PRIMARY KEY (order_id),
    CONSTRAINT fk_order_cust FOREIGN KEY (customer_id) REFERENCES customer (customer_id),
    CONSTRAINT fk_order_ship FOREIGN KEY (shipping_method_id) REFERENCES shipping_method (method_id),
    CONSTRAINT fk_order_addr FOREIGN KEY (dest_address_id) REFERENCES address (address_id)
);