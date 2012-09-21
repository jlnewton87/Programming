/**
 * Copyright (c) 2010 Surfsoft Consulting Limited (http://www.surfsoftconsulting.com)
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS"
 * BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 */
package uk.co.droidsoft.widget.wifi;

import android.appwidget.AppWidgetManager;
import android.appwidget.AppWidgetProvider;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.net.wifi.WifiManager;
import android.os.Bundle;
import android.util.Log;

public class WifiWidgetProvider extends AppWidgetProvider {

    private static final String TAG = WifiWidgetProvider.class.getName();

    protected static final String TOGGLE_STATE = "uk.co.droidsoft.widget.wifi.TOGGLE_STATE";

    @Override
    public void onUpdate(final Context context, final AppWidgetManager appWidgetManager, final int[] appWidgetIds) {

        Log.d(TAG, "onUpdate called with " + appWidgetIds.length + " widget ids");

        final Boolean state = WifiModel.getWifiState(context);
        final int resource = deriveResource(state);
        ViewHandler.updateAppWidgets(context, appWidgetManager, appWidgetIds, resource);

    }

    @Override
    public void onReceive(final Context context, final Intent intent) {

        Log.d(TAG, "onReceive called with intent " + intent.getAction());

        boolean handled = false;

        final String action = intent.getAction();
        if (AppWidgetManager.ACTION_APPWIDGET_DELETED.equals(action)) {
            handled = true;
            handleAppWidgetDeleted(context, intent);
        }

        if (WifiManager.WIFI_STATE_CHANGED_ACTION.equals(action)) {
            handled = true;
            final Boolean state = WifiModel.getWifiState(context);
            final int resource = deriveResource(state);
            updateWidgetView(context, resource);
        }

        if (TOGGLE_STATE.equals(action)) {
            handled = true;
            final Boolean wifiStatus = WifiModel.getWifiState(context);
            // ignore toggle requests if the wifi is currently changing state
            if (wifiStatus != null) {
                WifiModel.setWifiState(context, !wifiStatus);
                updateWidgetView(context, R.drawable.wifichanging);
            }
        }

        if (!handled) {
            super.onReceive(context, intent);
        }

    }

    @Override
    public void onEnabled(final Context context) {

        Log.d(TAG, "onEnabled called");

        final PackageManager pm = context.getPackageManager();
        pm.setComponentEnabledSetting(new ComponentName("uk.co.droidsoft.widget.wifi", ".WifiWidgetProvider"),
                        PackageManager.COMPONENT_ENABLED_STATE_ENABLED, PackageManager.DONT_KILL_APP);

    }

    @Override
    public void onDisabled(final Context context) {

        Log.d(TAG, "onDisabled called");

        final PackageManager pm = context.getPackageManager();
        pm.setComponentEnabledSetting(new ComponentName("uk.co.droidsoft.widget.wifi", ".WifiWidgetProvider"),
                        PackageManager.COMPONENT_ENABLED_STATE_DISABLED, PackageManager.DONT_KILL_APP);

    }

    private void handleAppWidgetDeleted(final Context context, final Intent intent) {

        final Bundle extras = intent.getExtras();
        final int appWidgetId = extras.getInt(AppWidgetManager.EXTRA_APPWIDGET_ID, AppWidgetManager.INVALID_APPWIDGET_ID);
        if (appWidgetId != AppWidgetManager.INVALID_APPWIDGET_ID) {
            this.onDeleted(context, new int[] {
                appWidgetId
            });
        }

    }

    private void updateWidgetView(final Context context, final int resource) {

        final AppWidgetManager appWidgetManager = AppWidgetManager.getInstance(context);
        final ComponentName thisWidget = new ComponentName(context, this.getClass());
        final int[] appWidgetIds = appWidgetManager.getAppWidgetIds(thisWidget);
        ViewHandler.updateAppWidgets(context, appWidgetManager, appWidgetIds, resource);

    }

    private int deriveResource(final Boolean state) {
        return state == null ? R.drawable.wifichanging : state ? R.drawable.wifion : R.drawable.wifioff;
    }

}
