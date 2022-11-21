CREATE TABLE address (
    address_id INT,
    street_number VARCHAR(10),
    street_name VARCHAR(200),
    city VARCHAR(100),
    country_id INT,
    CONSTRAINT pk_address PRIMARY KEY (address_id),
    CONSTRAINT fk_addr_ctry FOREIGN KEY (country_id) REFERENCES country (country_id)
);