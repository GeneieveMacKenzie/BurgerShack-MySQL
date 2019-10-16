-- price DECIMAL(5,2) //takes in two things first is total characters itll store and the second is 
-- id VARCHAR(255) NOT NULL //(You have to have an ID)
-- DEFAULT says if a value is not provided set it to .99 cents. default is 0
-- PRIMARY KEY (id) look up burgers by this value (id) you could look up by name,description,price. but ID is best
USE burgershack7;
CREATE TABLE burgers
(
    id VARCHAR(255) NOT NULL,
    name VARCHAR(255) NOT NULL,
    price DECIMAL(5,2) DEFAULT .99,
    description VARCHAR(255) NOT NULL,

    PRIMARY KEY (id)
)

--comment out to keep it from creating a new burger table

--THESE ARE OUR CRUD METHODS FOR SQL

--CREATE
-- INSERT INTO burgers
-- (id, name, price, description)
-- VALUES
-- ("123", "Bacon Burger", 8.99, "LOTS OF BACON");
-- ctrl alt d to add

--GET ALL
-- SELECT * FROM burgers; --select all columns for all the burgers

--GET BY (FIND)
-- SELECT * FROM burgers WHERE id = 123;

-- EDIT
-- UPDATE burgers
-- SET name = "bacon bacon burger"
-- WHERE id = 123; --DO NOT FORGET OR ALL BURGERS WILL BE CHANGED!!!!

--DROP TABLE burgers

-- DELETE FROM burgers WHERE id = 235; --deletes contents within table


