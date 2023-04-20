import javafx.application.Application;
import javafx.scene.Scene;
import javafx.stage.Stage;
import javafx.event.ActionEvent;
import javafx.geometry.HPos;
import javafx.geometry.Pos;
import javafx.scene.control.Label;
import javafx.scene.control.Alert;
import javafx.scene.control.ComboBox;
import javafx.scene.control.TextField;
import javafx.scene.layout.GridPane;
import javafx.scene.text.Font;

public class MilesKMConverter extends Application
{
    private Label result;
    private TextField input;
    private ComboBox<String> dropdown;
    static final double kilometersPerMile = 1.609;
    static final double milesPerKilometer = .621;
    
    public void start(Stage primaryStage){
        Font font = new Font(14);
        
        dropdown = new ComboBox<>();
        dropdown.getItems().addAll("Miles", "Kilometers");
        GridPane.setHalignment(dropdown, HPos.RIGHT);
    
        input = new TextField();
        input.setFont(font);
        input.setPrefWidth(50);
        input.setAlignment(Pos.CENTER);
        input.setOnAction(this::processReturn);
        
        result = new Label("---");
        result.setFont(font);
        GridPane.setHalignment(result, HPos.CENTER);
        
        //Initializing GridPane object
        GridPane GP = new GridPane();
        GP.setAlignment(Pos.CENTER);
        GP.setHgap(10);
        GP.setVgap(10);
        GP.setStyle("-fx-background-color: white");
        
        //Adding labels and combobox to gridpane
        GP.add(dropdown, 0, 0);
        GP.add(input, 1, 0);
        GP.add(result, 2, 0);
        GP.setFillWidth(dropdown, true);
        GP.setFillWidth(input, true);
        GP.setFillWidth(result, true);
        Scene scene = new Scene(GP, 500, 50);
        
        primaryStage.setTitle("Distance Converter");
        primaryStage.setScene(scene);
        primaryStage.show();
    }
    
    public void processReturn(ActionEvent event){
        double inputNum = Double.parseDouble(input.getText());
        
        String milesOrKilometers = dropdown.getValue();
        if (milesOrKilometers == null){
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setContentText("Please select an option");
            alert.showAndWait();
        }
        
        else if (milesOrKilometers == "Miles"){
            double kilometers = inputNum * kilometersPerMile;
            result.setText(inputNum + " Miles is equal to " + kilometers + " Kilometers.");
        }
        
        else if (milesOrKilometers == "Kilometers"){
            double miles = inputNum * milesPerKilometer;
            result.setText(inputNum + " Kilometers is equal to " + miles + " Miles.");
        }
    }
}
