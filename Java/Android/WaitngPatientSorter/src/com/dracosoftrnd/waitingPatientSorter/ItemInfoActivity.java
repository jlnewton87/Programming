package com.dracosoftrnd.waitingPatientSorter;

import android.app.Activity;
import android.os.Bundle;
import android.widget.TextView;

public class ItemInfoActivity extends Activity{

	public Patient giveInfo;
	
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.patient_info);
        Bundle extras = getIntent().getExtras();
        int index = extras.getInt("arrayIndex");
        giveInfo = PatientList.GlobalPatients.get(index);
        bindControls();
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
