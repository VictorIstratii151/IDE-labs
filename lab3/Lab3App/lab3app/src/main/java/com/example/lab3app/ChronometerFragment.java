package com.example.lab3app;

import android.content.Context;
import android.os.Bundle;
import android.os.Handler;
import android.os.SystemClock;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

/**
 * Created by vic on 5/6/17.
 */

public class ChronometerFragment extends Fragment
{
    Button btnStart, btnPause, btnLap;
    TextView txtTimer;
    Handler customHandler = new Handler();
    LinearLayout container2;

    long startTime = 0L;
    long timeInMilliseconds = 0L;
    long timeSwapBuff = 0L;
    long updateTime = 0L;

    public ChronometerFragment()
    {

    }

    public static ChronometerFragment newInstance()
    {
        ChronometerFragment fragment = new ChronometerFragment();
        return fragment;
    }

    Runnable UpdateTimerThread = new Runnable()
    {
        @Override
        public void run()
        {
            timeInMilliseconds = SystemClock.uptimeMillis() - startTime;
            updateTime = timeSwapBuff + timeInMilliseconds;
            int secs = (int) (updateTime / 1000);
            int mins = secs / 60;
            secs %= 60;
            int milliseconds = (int) (updateTime % 1000);
            txtTimer.setText("" + mins + ":" + String.format("%02d", secs) + ":"
                    + String.format("%03d", milliseconds));
            customHandler.postDelayed(this, 0);
        }
    };

    @Override
    public View onCreateView(final LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
        View rootView = inflater.inflate(R.layout.chrono_fragment, container, false);

        btnStart = (Button) rootView.findViewById(R.id.start);
        btnPause = (Button) rootView.findViewById(R.id.pause);
        btnLap = (Button) rootView.findViewById(R.id.lap);


        txtTimer = (TextView) rootView.findViewById(R.id.timerValue);
        container2 = (LinearLayout) rootView.findViewById(R.id.container);

        btnStart.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                startTime = SystemClock.uptimeMillis();

                customHandler.postDelayed(UpdateTimerThread, 0);

            }
        });

        btnPause.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                timeSwapBuff += timeInMilliseconds;
                customHandler.removeCallbacks(UpdateTimerThread);
            }
        });

        btnLap.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                //LayoutInflater inflater = (LayoutInflater)getBaseContext().getSystemService(Context.LAYOUT_INFLATER_SERVICE);
                View addView = inflater.inflate(R.layout.row, null);
                TextView txtValue = (TextView)addView.findViewById(R.id.txtContent);
                txtValue.setText(txtTimer.getText());
                container2.addView(addView);
            }
        });

        return rootView;
    }
}
