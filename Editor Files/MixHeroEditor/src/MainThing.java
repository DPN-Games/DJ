import com.sun.source.tree.SynchronizedTree;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

public class MainThing {
    private JPanel content;
    private JScrollPane HorizontalTrack;
    private JButton easyButton;
    private JButton mediumButton;
    private JButton hardButton;
    private JButton expertButton;
    private JButton skiptoStartButton;
    private JButton rewindButton;
    private JButton playButton;
    private JButton seekButton;
    private JButton skiptoEndButton;
    private JPanel buttonPanel;
    private JScrollPane VerticalScrollPane;
    private File workingFile;

    public MainThing(){
        ArrayList<String> noteList = new ArrayList<>();
        HorizontalTrack.setHorizontalScrollBarPolicy(ScrollPaneConstants.HORIZONTAL_SCROLLBAR_ALWAYS);
        JScrollBar horizScroll = new JScrollBar();
        horizScroll.setOrientation(Adjustable.HORIZONTAL);
        HorizontalTrack.setHorizontalScrollBar(horizScroll);
        skiptoStartButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e){
                horizScroll.setValue(0);
                HorizontalTrack.updateUI();
            }
        });
        rewindButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                horizScroll.setValue(horizScroll.getValue()-1);
                HorizontalTrack.updateUI();
            }
        });
        playButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

            }
        });
        seekButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                horizScroll.setValue(horizScroll.getValue()+1);
                HorizontalTrack.updateUI();
            }
        });
        skiptoEndButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                horizScroll.setValue(horizScroll.getMaximum());
                HorizontalTrack.updateUI();
            }
        });
        JScrollBar verticalScrollBar = new JScrollBar();
        verticalScrollBar.setOrientation(Adjustable.VERTICAL);
        VerticalScrollPane.setVerticalScrollBar(verticalScrollBar);
    }
    public JPanel getContent(){
        return content;
    }
    public void noteReader(File fileToRead){
        BufferedReader reader;
        try{
            reader = new BufferedReader(new FileReader(workingFile));
            String line = reader.readLine();
            while(line!=null) {
                String[] grab = line.split(" = ");
                int timing = Integer.parseInt(grab[0]);
                String noteData = grab[1];
                String[] notesData = noteData.split(",");
                int leftGreen = Integer.parseInt(notesData[0]);
                int Green = Integer.parseInt(notesData[1]);
                int Red = Integer.parseInt(notesData[2]);
                int Blue = Integer.parseInt(notesData[3]);
                int rightBlue = Integer.parseInt(notesData[4]);
                String event = notesData[5];
                ArrayList<String> events = new ArrayList<>();
                if (event.contains(";")) {
                    String[] mutliArray = event.split(";");
                    for (String b : mutliArray) {
                        events.add(b);
                    }
                }
                else {
                    events.add(event);
                }
                line = reader.readLine();
            }
        }
        catch(IOException ex){
            System.out.println("Error");
        }
    }
    public void setWorkingFile(File newWorkingFile){
        workingFile = newWorkingFile;
    }
}
