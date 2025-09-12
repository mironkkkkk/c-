SELECT * FROM Workers;
CREATE OR REPLACE FUNCTION increase_amout()
RETURN TRIGGER AS $$
BEGIN 
	UPDATE name
    SET amount = amount + 1