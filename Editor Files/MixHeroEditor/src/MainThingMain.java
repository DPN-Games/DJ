import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.*;

public class MainThingMain {
    private static MainThing mainer = new MainThing();
    public static void main(String[] args){
        JFrame frame = new JFrame();
        JMenuBar mb = new JMenuBar();
        //File Menu
        JMenu fileMenu = new JMenu("File");
        JMenuItem newButton = new JMenuItem("New");
        newButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String fileName = JOptionPane.showInputDialog(null, "Name of the Chart?");
                File newFile = new File(fileName+".txt");
                mainer.setWorkingFile(newFile);
                BufferedWriter writer;
                try{
                    writer = new BufferedWriter(new FileWriter(newFile.getAbsoluteFile()));
                    writer.write("==TRACK DATA==");
                    writer.close();
                }
                catch(IOException ex){
                    System.out.println("Error");
                }
            }
        });
        JMenuItem loadButton = new JMenuItem("Load");
        loadButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                final JFileChooser fc = new JFileChooser();
                mainer.setWorkingFile(fc.getSelectedFile());
            }
        });
        JMenuItem saveButton = new JMenuItem("Save");
        JMenuItem saveAsButton = new JMenuItem("Save As");
        JMenuItem quicksaveButton = new JMenuItem("Quick Save");
        JMenuItem loadOGGButton = new JMenuItem("Load OGG");
        JMenu ImportMenu = new JMenu("Import");
        JMenuItem sonicVisualizerButton = new JMenuItem("Sonic Visualizer");
        JMenuItem midiButton = new JMenuItem("MIDI");
        JMenuItem feedbackButton = new JMenuItem("Feedback");
        JMenuItem guitarheroButton = new JMenuItem("Guitar Hero");
        JMenuItem lyricButton = new JMenuItem("Lyric");
        JMenuItem guitarProButton = new JMenuItem("Guitar Pro");
        JMenuItem rocksmithButton = new JMenuItem("Rocksmith");
        JMenuItem bandfuseButton = new JMenuItem("Bandfuse");
        ImportMenu.add(sonicVisualizerButton);
        ImportMenu.add(midiButton);
        ImportMenu.add(feedbackButton);
        ImportMenu.add(guitarheroButton);
        ImportMenu.add(lyricButton);
        ImportMenu.add(guitarProButton);
        ImportMenu.add(rocksmithButton);
        ImportMenu.add(bandfuseButton);
        JMenuItem exportChartRangeButton = new JMenuItem("Export Chart Range");
        JMenuItem exportAudioRangeButton = new JMenuItem("Export Audio Range");
        JMenuItem exportGuitarProButton = new JMenuItem("Export Guitar Pro");
        fileMenu.add(newButton);
        fileMenu.add(loadButton);
        fileMenu.add(saveButton);
        fileMenu.add(saveAsButton);
        fileMenu.add(quicksaveButton);
        fileMenu.add(loadOGGButton);
        fileMenu.add(ImportMenu);
        fileMenu.add(exportChartRangeButton);
        fileMenu.add(exportAudioRangeButton);
        fileMenu.add(exportGuitarProButton);
        fileMenu.addSeparator();
        JMenuItem settingsButton = new JMenuItem("Settings");
        JMenu preferencesMenu = new JMenu("Preferences");
        JMenuItem preferencesButton = new JMenuItem("Preferences");
        JMenuItem importexportButton = new JMenuItem("Import/Export");
        preferencesMenu.add(preferencesButton);
        preferencesMenu.add(importexportButton);
        JMenu displayMenu = new JMenu("Display");
        JMenu notePanelMenu = new JMenu("Notes Panel");
        JMenuItem notesButton = new JMenuItem("Notes");
        JMenuItem notecontrolButton = new JMenuItem("Note Controls");
        JMenuItem informationPanelButton = new JMenuItem("Information Panel");
        JMenuItem noteCountsButton = new JMenuItem("Note Counts");
        JMenuItem userDefinedButton = new JMenuItem("User Defined");
        JMenuItem browseButton = new JMenuItem("Browse");
        notePanelMenu.add(notesButton);
        notePanelMenu.add(notecontrolButton);
        notePanelMenu.add(informationPanelButton);
        notePanelMenu.add(noteCountsButton);
        notePanelMenu.add(userDefinedButton);
        notePanelMenu.add(browseButton);
        notePanelMenu.addSeparator();
        JMenuItem enableButton = new JMenuItem("Enable");
        notePanelMenu.add(enableButton);
        JMenu threedPreviewMenu = new JMenu("3D Preview");
        JMenuItem setHOPOImageButton = new JMenuItem("Set HOPO Image Scale Size");
        JMenuItem setCameraAngleButton = new JMenuItem("Set Camera Angle");
        JMenuItem fullHeightButton = new JMenuItem("Full Height");
        threedPreviewMenu.add(setHOPOImageButton);
        threedPreviewMenu.add(setCameraAngleButton);
        threedPreviewMenu.add(fullHeightButton);
        JMenuItem displayButton = new JMenuItem("Display");
        JMenuItem setDisplayWidthButton = new JMenuItem("Set Display Width");
        JMenuItem twoxzoomButton = new JMenuItem("x2 Zoom");
        JMenuItem redrawButton = new JMenuItem("Redraw");
        JMenuItem benchmarkButton = new JMenuItem("Benchmark Image Sequence");
        displayMenu.add(notePanelMenu);
        displayMenu.add(threedPreviewMenu);
        displayMenu.add(displayButton);
        displayMenu.add(setDisplayWidthButton);
        displayMenu.add(twoxzoomButton);
        displayMenu.add(redrawButton);
        displayMenu.add(benchmarkButton);
        JMenuItem controllerButton = new JMenuItem("Controllers");
        JMenuItem songFolderButton = new JMenuItem("Song Folder");
        JMenuItem linktoFOFButton = new JMenuItem("Link to FOF");
        JMenuItem linktoPhaseShiftButton = new JMenuItem("Link to Phase Shift");
        JMenuItem linktoRocksmithToTabButton = new JMenuItem("Link to RocksmithToTab");
        fileMenu.add(settingsButton);
        fileMenu.add(preferencesMenu);
        fileMenu.add(displayMenu);
        fileMenu.add(controllerButton);
        fileMenu.add(songFolderButton);
        fileMenu.add(linktoFOFButton);
        fileMenu.add(linktoPhaseShiftButton);
        fileMenu.add(linktoRocksmithToTabButton);
        fileMenu.addSeparator();
        JMenuItem exitButton = new JMenuItem("Exit");
        fileMenu.add(exitButton);
        //Edit Menu
        JMenu editMenu = new JMenu("Edit");
        //Song Menu
        JMenu songMenu = new JMenu("Song");
        //Track Menu
        JMenu trackMenu = new JMenu("Track");
        //Note Menu
        JMenu noteMenu = new JMenu("Note");
        //Beat Menu
        JMenu beatMenu = new JMenu("Beat");
        //Help Menu
        JMenu helpMenu = new JMenu("Help");
        //Adds stuff to the menu bar
        mb.add(fileMenu);
        mb.add(editMenu);
        mb.add(songMenu);
        mb.add(trackMenu);
        mb.add(noteMenu);
        mb.add(beatMenu);
        mb.add(helpMenu);
        frame.setSize(300,300);
        JPanel mainPanel = new MainThing().getContent();
        frame.add(mainPanel);
        frame.add(BorderLayout.NORTH, mb);
        frame.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}
