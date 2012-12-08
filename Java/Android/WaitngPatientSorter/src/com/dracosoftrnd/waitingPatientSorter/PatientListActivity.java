package com.dracosoftrnd.waitingPatientSorter;

import java.util.ArrayList;

import android.os.Bundle;
import android.app.Activity;
import android.app.ListActivity;
import android.content.Intent;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.ArrayAdapter;
import android.widget.ListView;

public class PatientListActivity extends Activity {

	public static ArrayList<Patient> Patients;
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.patient_list);
        
        PatientListActivity.Patients = new ArrayList<Patient>();
        ListView patientList = (ListView) findViewById(android.R.id.list);
        PatientAdapter adapter = new PatientAdapter(this,
        		  PatientList.GlobalPatients);
        
        patientList.setAdapter(adapter);
        
    }

    @Override
    public void onResume(){
    	super.onResume();
         ListView patientList = (ListView) findViewById(android.R.id.list);
         PatientAdapter adapter = new PatientAdapter(this,
         		  PatientList.GlobalPatients);
         
         patientList.setAdapter(adapter);
    }
    
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.patient_list, menu);
        return true;
    }
    public boolean onOptionsItemSelected(MenuItem item)
    {
 
        switch (item.getItemId())
        {
        case R.id.add_patient:
            Intent addPatient = new Intent(getApplicationContext(), AddPatientActivity.class);
            startActivity(addPatient);
            return true;
        }
		return false;
    }
}
