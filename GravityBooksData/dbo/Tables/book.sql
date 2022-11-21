CREATE TABLE book (
    book_id INT,
    title VARCHAR(400),
    isbn13 VARCHAR(13),
    language_id INT,
    num_pages INT,
    publication_date DATE,
    publisher_id INT,
    CONSTRAINT pk_book PRIMARY KEY (book_id),
    CONSTRAINT fk_book_lang FOREIGN KEY (language_id) REFERENCES book_language (language_id),
    CONSTRAINT fk_book_pub FOREIGN KEY (publisher_id) REFERENCES publisher (publisher_id)
);