import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Polygon;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;

public class InteractiveHouse extends Application
{
    private Button colorButton;
    private boolean isBodyColorChanged; 
    
    @Override
    public void start(Stage primaryStage) {
        Rectangle body = new Rectangle(50, 200, 200, 150);
        body.setFill(Color.LIGHTBLUE);

        Polygon roof = new Polygon();
        roof.getPoints().addAll(new Double[]{
                50.0, 200.0,
                250.0, 200.0,
                150.0, 100.0});
        roof.setFill(Color.RED);

        Rectangle door = new Rectangle(125, 250, 50, 100);
        door.setFill(Color.GREY);

        Circle window1 = new Circle(90, 250, 25);
        window1.setFill(Color.YELLOW);
        Rectangle window2 = new Rectangle(185, 225, 50, 50);
        window2.setFill(Color.GREEN);
        
        colorButton = new Button("Change House Color");
         colorButton.setOnAction(event -> {
            if (isBodyColorChanged) {
                body.setFill(Color.LIGHTBLUE);
            } else {
                body.setFill(Color.ORANGE);
            }
            isBodyColorChanged = !isBodyColorChanged;
        });
        Group group = new Group(body, roof, door, window1, window2, colorButton);

        Scene scene = new Scene(group, 300, 400);

        primaryStage.setTitle("2D House Drawing");
        primaryStage.setScene(scene);
        primaryStage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
