package com.dracosoftrnd.waitingPatientSorter;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.widget.CheckBox;
import android.widget.TimePicker;

public class AddPatientActivity extends Activity {

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_patient);
        
        bindControls();
    }

    private void bindControls() {
    	TimePicker appointment = (TimePicker)this.findViewById(R.id.timeAppointment);
        appointment.setIs24HourView(true);
        
        TimePicker checkin = (TimePicker)this.findViewById(R.id.timeCheckin);
        checkin.setIs24HourView(true);
        
        CheckBox checkInNow = (CheckBox)this.findViewById(R.id.chkNow);
	}

	@Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.activity_add_patient, menu);
        return true;
    }
}
