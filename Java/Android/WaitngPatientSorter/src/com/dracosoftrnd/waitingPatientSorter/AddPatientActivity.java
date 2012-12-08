package com.dracosoftrnd.waitingPatientSorter;

import org.joda.time.LocalTime;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.TimePicker;
import android.widget.Toast;

public class AddPatientActivity extends Activity {

	
	private Patient newPatient = null;
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_patient);
        
        bindControls();
    }

    private void bindControls() {
    	final EditText txtName = (EditText)this.findViewById(R.id.txtName);
    	
    	final TimePicker appointment = (TimePicker)this.findViewById(R.id.timeAppointment);
        appointment.setIs24HourView(true);
        
        final TimePicker checkin = (TimePicker)this.findViewById(R.id.timeCheckin);
        checkin.setIs24HourView(true);
        
    	Button btnAdd = (Button)this.findViewById(R.id.btnAdd);
    	btnAdd.setOnClickListener(new Button.OnClickListener() {

			public void onClick(View v) {
				if (txtName.getText().toString().matches(""))
				{
					Toast.makeText(AddPatientActivity.this, "Please enter patient's name", Toast.LENGTH_SHORT).show();
					return;
				}
				else
				{
				String name = txtName.getText().toString();
				int apptHour = appointment.getCurrentHour();
				int apptMinute = appointment.getCurrentMinute();
				LocalTime apptTime = new LocalTime(apptHour, apptMinute);
				int checkinHour = checkin.getCurrentHour();
				int checkinMinute = checkin.getCurrentMinute();
				LocalTime checkinTime = new LocalTime(checkinHour, checkinMinute);
				newPatient = new Patient(name, apptTime, checkinTime);
				PatientList.GlobalPatients.add(newPatient);
				Intent listPatients = new Intent(getApplicationContext(), PatientListActivity.class);
	            startActivity(listPatients);
				}
			}
    	});
    	
    	Button btnCancel = (Button)this.findViewById(R.id.btnCancel);
    	btnCancel.setOnClickListener(new Button.OnClickListener() {
    	    public void onClick(View v) {
    	    	newPatient = null;
                AddPatientActivity.this.finish();
        }
    });

	}

	@Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.activity_add_patient, menu);
        return true;
    }
}
