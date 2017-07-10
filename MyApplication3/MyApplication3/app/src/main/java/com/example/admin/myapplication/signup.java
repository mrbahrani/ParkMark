package com.example.admin.myapplication;

/**
 * Created by Admin on 7/10/2017.
 */


        import android.app.Activity;
        import android.content.Intent;
        import android.os.Bundle;
        import android.view.TextureView;
        import android.view.View;
        import android.view.Window;
        import android.view.WindowManager;
        import android.widget.TextView;

public class signup  extends Activity {

    @SuppressWarnings("deprecation")
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        //Remove title bar
        this.requestWindowFeature(Window.FEATURE_NO_TITLE);

        //Remove notification bar
        this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        //set content view AFTER ABOVE sequence (to avoid crash)
        this.setContentView(R.layout.fragment_signup);
        TextView signin = (TextView) findViewById(R.id.textView1);
        signin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(signup.this,signin.class);
                startActivity(i);
                finish();
            }
        });

    }

}

