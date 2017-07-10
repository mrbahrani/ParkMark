package com.example.admin.myapplication;

/**
 * Created by Admin on 7/10/2017.
 */


import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class signin  extends Activity {
    String username="erfan@yahoo.com";
    String password="1234";
    EditText user;
    EditText pass;
    @SuppressWarnings("deprecation")
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        //Remove title bar
        this.requestWindowFeature(Window.FEATURE_NO_TITLE);
        //Remove notification bar
        this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);
        //set content view AFTER ABOVE sequence (to avoid crash)
        this.setContentView(R.layout.fragment_login);
        user = (EditText) findViewById(R.id.editText1);
        pass = (EditText) findViewById(R.id.editText3);
        TextView signup = (TextView) findViewById(R.id.textView1);
        signup.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(signin.this,signup.class);
                startActivity(i);
                //finish();
            }
        });
        Button login = (Button) findViewById(R.id.button1);
        login.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View arg0) {

                // TODO Auto-generated method stub
              // if(username.equalsIgnoreCase(user.getText().toString()) && password.equalsIgnoreCase(pass.getText().toString()))

                {
                   //System.out.println("okay");
                    Intent i = new Intent(signin.this,MapsActivity.class);
                    startActivity(i);
                }
            }
        });
    }

}

