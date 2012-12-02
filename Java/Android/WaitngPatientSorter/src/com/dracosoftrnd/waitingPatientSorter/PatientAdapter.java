package com.dracosoftrnd.waitingPatientSorter;

import java.util.ArrayList;

import com.dracosoftrnd.waitingPatientSorter.R.color;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.content.Context;
import android.graphics.Color;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

public class PatientAdapter extends BaseAdapter{
	
	private Activity activity;
	private ArrayList<Patient> patients;
    private static LayoutInflater inflater = null;
	
	public PatientAdapter(Activity a, ArrayList<Patient> patientList)
	{
		activity = a;
		patients = patientList;
		inflater = (LayoutInflater)activity.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
	}

	public int getCount() {
		// TODO Auto-generated method stub
		return patients.size();
	}

	public Object getItem(int position) {
        return position;
    }

	public long getItemId(int position) {
		// TODO Auto-generated method stub
		return position;
	}

	public View getView(int position, View convertView, ViewGroup parent) {
		 View vi=convertView;
	        if(convertView==null)
	            vi = inflater.inflate(R.layout.list_row, null);
	 
	        TextView title = (TextView)vi.findViewById(R.id.patientName); // Name
	        TextView time = (TextView)vi.findViewById(R.id.effectiveTime); //Effective Time
	        ImageView image = (ImageView)vi.findViewById(R.id.image1);
	        
	        Patient patient = patients.get(position);
	 
	        // Setting all values in listview
	        title.setText(patient.name);
	        time.setText(patient.effectiveTime.toString());
	        if(patient.differenceInMinutes == 0)
	        {
	        	image.setImageResource(R.drawable.circle_yellow);
	        }
	        else if(patient.differenceInMinutes > 0)
	        {
	        	image.setImageResource(R.drawable.circle_red);
	        }
	        else if(patient.differenceInMinutes < 0)
	        {
	        	image.setImageResource(R.drawable.circle_green);
	        }
	        return vi;
	}

}
