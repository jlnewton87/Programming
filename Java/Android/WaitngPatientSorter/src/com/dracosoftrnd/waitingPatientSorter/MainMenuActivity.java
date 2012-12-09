package com.dracosoftrnd.waitingPatientSorter;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainMenuActivity extends Activity{

	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main_menu);
        
        bindControls();
        
    }

	private void bindControls() {
		Button btnPatientList = (Button)this.findViewById(R.id.btnPatientList);
		Button btnAddPatient = (Button)this.findViewById(R.id.btnAddPatient);
		
		btnPatientList.setOnClickListener(new Button.OnClickListener() {
    	    public void onClick(View v) {
    	    	Intent listPatients = new Intent(getApplicationContext(), PatientListActivity.class);
	            startActivity(listPatients);
        }
    });
		
		btnAddPatient.setOnClickListener(new Button.OnClickListener() {
    	    public void onClick(View v) {
    	    	Intent addPatient = new Intent(getApplicationContext(), AddPatientActivity.class);
	            startActivity(addPatient);
        }
    });
		
	}
	
}
