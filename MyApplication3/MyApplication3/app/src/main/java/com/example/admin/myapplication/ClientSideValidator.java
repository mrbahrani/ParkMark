package com.example.erfan.parkmark;

public class ClientSideValidator {

    public static boolean checkEmail(String email){
        String ePattern = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\])|(([a-zA-Z\\-0-9]+\\.)+[a-zA-Z]{2,}))$";
        java.util.regex.Pattern p = java.util.regex.Pattern.compile(ePattern);
        java.util.regex.Matcher m = p.matcher(email);
        return m.matches();
    }

    public static boolean checkPassword(String password){
        if(password.length() < 6 || password.length() > 20) return false;
        String notWhiteSpace = "[^\\\\s]";
        if(password.matches(notWhiteSpace)) return false;   // Password has whitespaces and it's illegal.
        String pattern = "^[a-zA-Z0-9!#$%&'()*+,-./:;<=>?@^_`{|}~]*$";
        return password.matches(pattern);
    }
}
