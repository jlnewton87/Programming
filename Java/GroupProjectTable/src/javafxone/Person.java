/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package javafxone;

import javafx.beans.property.SimpleStringProperty;

/**
 *
 * @author josh
 */
public class Person {
 
        public final SimpleStringProperty firstName;
        public final SimpleStringProperty lastName;
        public final SimpleStringProperty email;
 
        public Person(String fName, String lName, String email) {
            this.firstName = new SimpleStringProperty(fName);
            this.lastName = new SimpleStringProperty(lName);
            this.email = new SimpleStringProperty(email);
        }
 
        public String getFirstName() {
            return firstName.get();
        }
 
        public void setFirstName(String fName) {
            firstName.set(fName);
        }
 
        public String getLastName() {
            return lastName.get();
        }
 
        public void setLastName(String fName) {
            lastName.set(fName);
        }
 
        public String getEmail() {
            return email.get();
        }
 
        public void setEmail(String fName) {
            email.set(fName);
        }
    }
