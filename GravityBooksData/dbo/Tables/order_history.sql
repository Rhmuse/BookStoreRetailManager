CREATE TABLE order_history (
    history_id INT IDENTITY,
    order_id INT,
    status_id INT,
    status_date DATETIME,
    CONSTRAINT pk_orderhist PRIMARY KEY (history_id),
    CONSTRAINT fk_oh_order FOREIGN KEY (order_id) REFERENCES cust_order (order_id),
    CONSTRAINT fk_oh_status FOREIGN KEY (status_id) REFERENCES order_status (status_id)
);