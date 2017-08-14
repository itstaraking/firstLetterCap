package com.company;

// import scanner class
import javax.print.DocFlavor;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    // give instruction
        System.out.print("Enter a sentence and I will capitalize each word: ");

        // create scanner object
        Scanner keyboard = new Scanner(System.in);

        // create variable to hold input
        String input = keyboard.nextLine();

        for (String word:input.split(" ")
             )
        {
            System.out.println(word.substring(0,1).toUpperCase() + word.substring(1));
        }

    }
}
