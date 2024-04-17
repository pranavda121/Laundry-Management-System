CREATE OR REPLACE PROCEDURE ChangeStudentPassword (
    p_student_id IN NUMBER,
    p_new_password IN VARCHAR2
)
IS
    v_count NUMBER;
BEGIN
    -- Check if the student with the given ID exists
    SELECT COUNT(*)
    INTO v_count
    FROM STUDENT
    WHERE STUDENT_ID = p_student_id;

    IF v_count = 1 THEN
        -- Update the password for the student
        UPDATE STUDENT
        SET PASSWORD = p_new_password
        WHERE STUDENT_ID = p_student_id;
        
        -- Output a success message
        DBMS_OUTPUT.PUT_LINE('Password updated successfully.');
    ELSE
        -- Output an error message if the student ID does not exist
        DBMS_OUTPUT.PUT_LINE('Student ID does not exist.');
    END IF;
EXCEPTION
    WHEN OTHERS THEN
        -- Output an error message if any exception occurs
        DBMS_OUTPUT.PUT_LINE('An error occurred: ' || SQLERRM);
END;
/
