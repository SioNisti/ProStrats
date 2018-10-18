package prostrats;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.input.KeyCode;
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.scene.text.Font;
import javafx.scene.text.Text;
import javafx.stage.Stage;

public class ProStrats extends Application{
	
	int s = 0;
	int f = 0;
	
	public static void main(String[] args) {
		launch();
	}

	@Override
	public void start(Stage primaryStage) throws Exception {
		VBox root = new VBox();
		root.setPrefWidth(350);
		root.setPrefHeight(130);
		Button b = new Button("Reset");
		root.getChildren().add(b);
		HBox fail = new HBox();
		Text failT = new Text("Failed: 0");
		failT.setFont(Font.font("Arial", 20));
		Text downArrow = new Text("(down arrow)");
		fail.getChildren().addAll(downArrow, failT);
		HBox success = new HBox();
		Text upArrow = new Text("(up arrow)");
		Text successT = new Text("Success: 0");
		successT.setFont(Font.font("Arial", 20));
		success.getChildren().addAll(upArrow, successT);
		Text consistency = new Text("Consistency: 0%");
		consistency.setFont(Font.font ("Arial", 40));
		root.getChildren().addAll(success, fail, consistency);
		Scene scene = new Scene(root);
		
		b.setOnAction(e -> {
			s = 0;
			f = 0;
			successT.setText("Success: " + String.valueOf(s));
			failT.setText("Failed: " + String.valueOf(f));
			consistency.setText("Consistency: 0%");
		});
		
		scene.setOnKeyPressed(e -> {
			if (e.getCode() == KeyCode.UP) {
				s++;
				successT.setText("Success: " + String.valueOf(s));
			} else if (e.getCode() == KeyCode.DOWN) {
				f++;
				failT.setText("Failed: " + String.valueOf(f));
			}
			double c = ((double) s / (double) (s + f)) * 100.0;
			consistency.setText("Consistency: " + Math.round(Double.valueOf(c)) + "%");
		});
		
		primaryStage.setScene(scene);
		primaryStage.show();
	}
}
