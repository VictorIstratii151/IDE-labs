package com.example.lab3app;

import android.os.Bundle;
import android.os.CountDownTimer;
import android.os.WorkSource;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

import org.w3c.dom.Text;

/**
 * Created by vic on 5/7/17.
 */

public class PomodoroFragment extends Fragment
{
    CountDownTimer Worktimer;
    CountDownTimer restTimer;
    CountDownTimer bigRestTimer;
    TextView timeToWork;
    TextView timeToRest;
    TextView pomodorosEarned;
    Button btnStart;
    Button btnStop;
    Button btnReset;
    int pomodoroCount = 0;

    public PomodoroFragment()
    {

    }

    public static PomodoroFragment newInstance()
    {
        PomodoroFragment fragment = new PomodoroFragment();
        return fragment;
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
        View rootView = inflater.inflate(R.layout.fragment_pomodoro, container, false);

        timeToWork = (TextView) rootView.findViewById(R.id.timeToWork);
        timeToRest = (TextView) rootView.findViewById(R.id.timeToRest);
        pomodorosEarned = (TextView) rootView.findViewById(R.id.pomodorosEarned);

        btnStart = (Button) rootView.findViewById(R.id.pmdr_start);
        btnStop = (Button) rootView.findViewById(R.id.pmdr_stop);
        btnReset = (Button) rootView.findViewById(R.id.pmdr_reset);


        Worktimer =  new CountDownTimer(10000, 1000)
        {
            @Override
            public void onTick(long millisUntilFinished)
            {
                long seconds = millisUntilFinished / 1000;
                String timeToS = String.format("%02d:%02d", seconds / 60, seconds % 60);
                timeToWork.setText(getString(R.string.work_left) + timeToS);
            }

            @Override
            public void onFinish()
            {
                timeToWork.setText(R.string.work_left);
                if(pomodoroCount != 0 && pomodoroCount % 3 == 0)
                {
                    bigRestTimer.start();
                }
                else
                {
                    restTimer.start();
                }
            }
        };

        restTimer = new CountDownTimer(5000, 1000) {
            @Override
            public void onTick(long millisUntilFinished)
            {
                long seconds = millisUntilFinished / 1000;
                String timeToS = String.format("%02d:%02d", seconds / 60, seconds % 60);
                timeToRest.setText(getString(R.string.rest_left) + timeToS);
            }

            @Override
            public void onFinish()
            {
                pomodoroCount += 1;
                if(pomodoroCount != 0 && pomodoroCount % 3 == 0)
                {
                    timeToRest.setText(R.string.rest_left);
                    pomodorosEarned.setText(getString(R.string.pomodoros_earned ) + Integer.toString(pomodoroCount));
                    bigRestTimer.start();
                }
                else
                {
                    timeToRest.setText(R.string.rest_left);
                    pomodorosEarned.setText(getString(R.string.pomodoros_earned ) + Integer.toString(pomodoroCount));
                    Worktimer.start();
                }
            }
        };

        bigRestTimer = new CountDownTimer(10000, 1000) {
            @Override
            public void onTick(long millisUntilFinished)
            {
                long seconds = millisUntilFinished / 1000;
                String timeToS = String.format("%02d:%02d", seconds / 60, seconds % 60);
                timeToRest.setText(getString(R.string.rest_left) + timeToS);
            }

            @Override
            public void onFinish()
            {
                timeToRest.setText(getString(R.string.rest_left));
                Worktimer.start();
            }
        };



        btnStart.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                Worktimer.start();
                timeToRest.setText(getString(R.string.rest_left));
            }
        });

        btnStop.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                Worktimer.cancel();
                restTimer.cancel();
                bigRestTimer.cancel();
            }
        });

        btnReset.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                pomodoroCount = 0;
                pomodorosEarned.setText(getString(R.string.pomodoros_earned));
                timeToWork.setText(getString(R.string.work_left));
                timeToRest.setText(getString(R.string.rest_left));
                Worktimer.cancel();
                restTimer.cancel();
                bigRestTimer.cancel();
            }
        });

        //Worktimer.start();



        return  rootView;
    }
}