CREATE TABLE order_line (
    line_id INT IDENTITY,
    order_id INT,
    book_id INT,
    price DECIMAL(5, 2),
    CONSTRAINT pk_orderline PRIMARY KEY (line_id),
    CONSTRAINT fk_ol_order FOREIGN KEY (order_id) REFERENCES cust_order (order_id),
    CONSTRAINT fk_ol_book FOREIGN KEY (book_id) REFERENCES book (book_id)
);