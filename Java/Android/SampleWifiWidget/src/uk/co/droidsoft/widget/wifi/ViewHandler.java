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

import android.app.PendingIntent;
import android.appwidget.AppWidgetManager;
import android.content.Context;
import android.content.Intent;
import android.util.Log;
import android.widget.RemoteViews;

public class ViewHandler {

    private static final String TAG = ViewHandler.class.getName();

    protected static void updateAppWidgets(final Context context, final AppWidgetManager appWidgetManager,
                    final int[] appWidgetIds, final int resource) {

        Log.d(TAG, "updateAppWidgets called called with " + appWidgetIds.length + " widget ids");

        for (int i = 0; i < appWidgetIds.length; i++) {
            final int appWidgetId = appWidgetIds[i];
            updateAppWidget(context, appWidgetManager, appWidgetId, resource);
        }

    }

    private static void updateAppWidget(final Context context, final AppWidgetManager appWidgetManager, final int appWidgetId,
                    final int resource) {

        Log.d(TAG, "updateAppWidget called for appWidgetId " + appWidgetId);

        final RemoteViews views = new RemoteViews(context.getPackageName(), R.layout.wifi_widget);

        views.setImageViewResource(R.id.WifiStatus, resource);
        final PendingIntent pendingIntent = PendingIntent.getBroadcast(context, 0, new Intent(WifiWidgetProvider.TOGGLE_STATE),
                        PendingIntent.FLAG_UPDATE_CURRENT);
        views.setOnClickPendingIntent(R.id.WifiStatus, pendingIntent);
        appWidgetManager.updateAppWidget(appWidgetId, views);

    }

}
