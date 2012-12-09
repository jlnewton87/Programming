package com.dracosoftrnd.waitingPatientSorter;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;

public class ItemInfoActivity extends Activity{

	private Patient giveInfo;
	private int index;
	
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.patient_info);
        Bundle extras = getIntent().getExtras();
        index = extras.getInt("arrayIndex");
        giveInfo = PatientList.GlobalPatients.get(index);
        bindControls();
	}

	 @Override
	    public boolean onCreateOptionsMenu(Menu menu) {
	        getMenuInflater().inflate(R.menu.item_info, menu);
	        return true;
	    }
	    public boolean onOptionsItemSelected(MenuItem item)
	    {
	 
	        switch (item.getItemId())
	        {
	        case R.id.remove_patient:
	        	PatientList.GlobalPatients.remove(index);
	        	Intent listPatients = new Intent(getApplicationContext(), PatientListActivity.class);
	            startActivity(listPatients);
	        }
			return false;
	    }
	
	private void bindControls() {
		TextView txtName = (TextView)this.findViewById(R.id.patientName);
		TextView txtAppointmentTime = (TextView)this.findViewById(R.id.patientAppointmentTime);
		TextView txtCheckinTime = (TextView)this.findViewById(R.id.patientCheckinTime);
		TextView txtEffectiveTime = (TextView)this.findViewById(R.id.patientEffectiveTime);
		
		String effectiveTime = giveInfo.checkinTime.toString().replace(":00.000", "") + " " + "+" + " " + 
				giveInfo.differenceInMinutes + " " + "minutes" + " " + "=" + 
				giveInfo.effectiveTime.toString().replace(":00.000", "");
		
		txtName.setText(giveInfo.name);
		txtAppointmentTime.setText(giveInfo.appointmentTime.toString().replace(":00.000", ""));
		txtCheckinTime.setText(giveInfo.checkinTime.toString().replace(":00.000", ""));
		txtEffectiveTime.setText(effectiveTime);
	}
}
