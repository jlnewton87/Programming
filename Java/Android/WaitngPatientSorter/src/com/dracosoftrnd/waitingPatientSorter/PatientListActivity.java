package com.dracosoftrnd.waitingPatientSorter;

import java.util.ArrayList;

import android.os.Bundle;
import android.app.Activity;
import android.app.ListActivity;
import android.view.Menu;
import android.widget.ArrayAdapter;
import android.widget.ListView;

public class PatientListActivity extends Activity {

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.patient_list);
        
        ArrayList<Patient> patients = PatientList.loadTestData();
        ListView patientList = (ListView) findViewById(android.R.id.list);
        PatientAdapter adapter = new PatientAdapter(this,
        		  patients);
        
        patientList.setAdapter(adapter);
        
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.patient_list, menu);
        return true;
    }
}
