To Run same 'TaxProEwb.Java.API' jar file, in java as well as in android, We have done some below changes

Following Changes is included in new JAR file

 
1. Http Client Changed, okhttp3 Client used instate of org.apache.http.client
   below is library name added from maven

   com.squareup.okhttp3:benchmarks:3.7.0

2. Instate of local date time, joda-time used
   below is library name added from maven

   joda-time:joda-time:2.9.4
