package com.dracosoftrnd.waitingPatientSorter;

import java.util.ArrayList;
import java.util.Collections;
import android.os.Bundle;
import android.app.Activity;
import android.app.ListActivity;
import android.content.Intent;
import android.util.Log;
import android.view.ContextMenu;
import android.view.ContextMenu.ContextMenuInfo;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.AdapterView.OnItemLongClickListener;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

public class PatientListActivity extends ListActivity {

	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.patient_list);
        setAdapter();
        
    }

    @Override
    public void onResume(){
    	super.onResume();
         setAdapter();
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
        case R.id.load_testData:
        	PatientList.loadTestData();
            setAdapter();
        }
		return false;
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v,
        ContextMenuInfo menuInfo) {
      if (v.getId()==android.R.id.list) {
        AdapterView.AdapterContextMenuInfo info = (AdapterView.AdapterContextMenuInfo)menuInfo;
        menu.add(Menu.NONE, 1, 1, "Remove Patient");
      }
    }
    
    @Override
    public boolean onContextItemSelected(MenuItem item) {
      AdapterView.AdapterContextMenuInfo info = (AdapterView.AdapterContextMenuInfo)item.getMenuInfo();
      int menuItemIndex = item.getItemId();
      if(menuItemIndex == 1)
      {
    	  PatientList.GlobalPatients.remove(info.position);
    	  setAdapter();
      }
        return true;
    }
    
	private void setAdapter() {
		ListView patientList = (ListView) findViewById(android.R.id.list);
        Collections.sort(PatientList.GlobalPatients);
        PatientAdapter adapter = new PatientAdapter(this,
        		  PatientList.GlobalPatients);
        
        patientList.setAdapter(adapter);
        registerForContextMenu(patientList);
	}
	
}
