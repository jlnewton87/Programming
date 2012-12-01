package com.dracosoftrnd.waitingPatientSorter;

import org.joda.time.*;

public class Patient {
	
	public String name;
	public LocalTime appointmentTime;
	public LocalTime checkinTime;
	public LocalTime effectiveTime;
	public int differenceInMinutes;
	
	
	public Patient(String name, LocalTime appointment, LocalTime checkin)
	{
		this.name = name;
		this.appointmentTime = appointment;
		this.checkinTime = checkin;
		this.differenceInMinutes = Integer.parseInt(Minutes.minutesBetween(appointment, checkin).toString().replace("PT", "").replace("M", ""));
		this.effectiveTime = appointment.plusMinutes(differenceInMinutes);
	}
}