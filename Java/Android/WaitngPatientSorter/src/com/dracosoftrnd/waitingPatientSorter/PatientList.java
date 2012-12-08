package com.dracosoftrnd.waitingPatientSorter;

import java.util.*;
import org.joda.time.LocalTime;

public class PatientList {
	
	public static ArrayList<Patient> GlobalPatients = new ArrayList<Patient>();
	public static Patient TestLoadData = new Patient("C3PO", new LocalTime(16, 00), new LocalTime(15, 50));
	
	public static void loadTestData()
	{
		Patient a = new Patient("Joshua Newton", new LocalTime(13, 30), new LocalTime(13, 39));
		Patient b = new Patient("John Doe", new LocalTime(14, 00), new LocalTime(13, 58));
		Patient c = new Patient("Jane Doe", new LocalTime(14, 30), new LocalTime(13, 25));
		Patient d = new Patient("Eric Clapton", new LocalTime(15, 00), new LocalTime(15, 05));
		Patient e = new Patient("Lady Gaga", new LocalTime(15, 30), new LocalTime(15, 30));
		Patient f = new Patient("Taylor Swift", new LocalTime(16, 30), new LocalTime(16, 50));
		Patient g = new Patient("C3PO", new LocalTime(16, 00), new LocalTime(15, 50));
		GlobalPatients.add(a);
		GlobalPatients.add(b);
		GlobalPatients.add(c);
		GlobalPatients.add(d);
		GlobalPatients.add(e);
		GlobalPatients.add(f);
		GlobalPatients.add(g);
	}
}
