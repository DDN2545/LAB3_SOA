package th.ac.ku.kps.eng.cpe.soa.service.impl;

import jakarta.xml.ws.Endpoint;

public class UCPublisher {
	public static void main(String[] args) {
// TODO Auto-generated method stub
		Endpoint.publish("http://localhost:8080/UC", new UnitConverstionImpl());
	}
}