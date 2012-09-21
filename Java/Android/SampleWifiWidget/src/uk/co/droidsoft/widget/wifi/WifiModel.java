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

import android.content.Context;
import android.net.wifi.WifiManager;
import android.util.Log;

public class WifiModel {

    private static final String TAG = WifiModel.class.getName();

    protected static Boolean getWifiState(final Context context) {

        final WifiManager wifiManager = (WifiManager) context.getSystemService(Context.WIFI_SERVICE);
        final Boolean wifiState;

        switch (wifiManager.getWifiState()) {
        case WifiManager.WIFI_STATE_DISABLED:
            wifiState = false;
            break;
        case WifiManager.WIFI_STATE_DISABLING:
            wifiState = null;
            break;
        case WifiManager.WIFI_STATE_ENABLED:
            wifiState = true;
            break;
        case WifiManager.WIFI_STATE_ENABLING:
            wifiState = null;
            break;
        case WifiManager.WIFI_STATE_UNKNOWN:
            wifiState = false;
            break;
        default:
            wifiState = false;
        }

        Log.v(TAG, "getWifiState - wifiState is " + wifiState);

        return wifiState;

    }

    public static void setWifiState(final Context context, final boolean wifiState) {

        Log.v(TAG, "setWifiState - wifiState is " + wifiState);

        final WifiManager wifiManager = (WifiManager) context.getSystemService(Context.WIFI_SERVICE);
        wifiManager.setWifiEnabled(wifiState);

    }

}
