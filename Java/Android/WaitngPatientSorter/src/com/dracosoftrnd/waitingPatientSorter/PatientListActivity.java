package com.dracosoftrnd.waitingPatientSorter;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;

public class PatientListActivity extends Activity {

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.patient_list);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.patient_list, menu);
        return true;
    }
}
