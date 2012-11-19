package com.dracosoftrnd.waitingPatientSorter;

import java.util.Date;

public class Patient {
	
	public String firstName;
	public String lastName;
	public Date appointmentTime;
	public Date checkinTime;
	public Date effectiveTime;
	
	
	public Patient(String fName, String lName, Date appointmentTime, Date checkinTime, Date effectiveTime)
	{
		this.firstName = fName;
		this.lastName = lName;
		this.appointmentTime = appointmentTime;
		this.checkinTime = checkinTime;
		this.effectiveTime = effectiveTime;
	}
}
