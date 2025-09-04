-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: PWCServerPag    Database: pamanawater_inventory
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `branch_stocks`
--

DROP TABLE IF EXISTS `branch_stocks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `branch_stocks` (
  `id` int NOT NULL AUTO_INCREMENT,
  `stocks_id` int NOT NULL,
  `branches_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_store_stocks_stocks1_idx` (`stocks_id`),
  KEY `fk_store_stocks_stores1_idx` (`branches_id`),
  CONSTRAINT `fk_store_stocks_stocks1` FOREIGN KEY (`stocks_id`) REFERENCES `stocks` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_store_stocks_stores1` FOREIGN KEY (`branches_id`) REFERENCES `branches` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `branch_stocks`
--

LOCK TABLES `branch_stocks` WRITE;
/*!40000 ALTER TABLE `branch_stocks` DISABLE KEYS */;
/*!40000 ALTER TABLE `branch_stocks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `branches`
--

DROP TABLE IF EXISTS `branches`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `branches` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(99) NOT NULL,
  `address` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `branches`
--

LOCK TABLES `branches` WRITE;
/*!40000 ALTER TABLE `branches` DISABLE KEYS */;
INSERT INTO `branches` VALUES (7,'Pamana - Pagadian','Pagadian City, Zamboanga Del Sur'),(8,'Pamana - Dagupan','Dagupan, Philippines'),(9,'Pamana - Head Office','900 Romualdez St. Paco Manila');
/*!40000 ALTER TABLE `branches` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `business_details`
--

DROP TABLE IF EXISTS `business_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `business_details` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(99) NOT NULL,
  `address` varchar(99) DEFAULT NULL,
  `permit_no` varchar(45) DEFAULT NULL,
  `tin` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `business_details`
--

LOCK TABLES `business_details` WRITE;
/*!40000 ALTER TABLE `business_details` DISABLE KEYS */;
INSERT INTO `business_details` VALUES (1,'PAMANA WATER CORPORATION','900 Romualdez St. Paco Manila','001',NULL);
/*!40000 ALTER TABLE `business_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(99) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='	';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (15,'IT Supplies'),(16,'Office Supplies'),(17,'Plumbing'),(18,'Vehicle');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `items` (
  `id` int NOT NULL AUTO_INCREMENT,
  `categories_id` int NOT NULL,
  `unit_measurements_id` int NOT NULL,
  `code` varchar(45) NOT NULL,
  `name` varchar(99) NOT NULL,
  `updated_by` int DEFAULT NULL,
  `updated_time` timestamp NULL DEFAULT NULL,
  `created_by` int NOT NULL,
  `created_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_items_categories_idx` (`categories_id`),
  KEY `fk_items_unit_measurements1_idx` (`unit_measurements_id`),
  KEY `fk_items_users1_idx` (`created_by`),
  KEY `fk_items_users2_idx` (`updated_by`),
  CONSTRAINT `fk_items_categories` FOREIGN KEY (`categories_id`) REFERENCES `categories` (`id`),
  CONSTRAINT `fk_items_unit_measurements1` FOREIGN KEY (`unit_measurements_id`) REFERENCES `unit_measurements` (`id`),
  CONSTRAINT `fk_items_users1` FOREIGN KEY (`created_by`) REFERENCES `users` (`id`),
  CONSTRAINT `fk_items_users2` FOREIGN KEY (`updated_by`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=121 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items`
--

LOCK TABLES `items` WRITE;
/*!40000 ALTER TABLE `items` DISABLE KEYS */;
INSERT INTO `items` VALUES (74,15,15,'IT-002','Woosim Printers',1,NULL,1,'2025-06-11 02:50:25'),(111,15,15,'LTP','Laptops',1,NULL,1,'2025-07-02 05:47:57'),(112,15,15,'TLBT','Tablets',1,NULL,1,'2025-07-03 06:32:09'),(120,18,15,'MTC','Motorcycle',1,NULL,1,'2025-09-02 06:29:25');
/*!40000 ALTER TABLE `items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permissions`
--

DROP TABLE IF EXISTS `permissions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permissions` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(99) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permissions`
--

LOCK TABLES `permissions` WRITE;
/*!40000 ALTER TABLE `permissions` DISABLE KEYS */;
/*!40000 ALTER TABLE `permissions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personnel` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(250) NOT NULL,
  `contact_info` varchar(99) DEFAULT NULL,
  `address` varchar(250) DEFAULT NULL,
  `designation` varchar(100) NOT NULL,
  `created_by` int NOT NULL,
  `created_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_time` timestamp NULL DEFAULT NULL,
  `updated_by` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_personnels_users1_idx` (`created_by`),
  KEY `fk_personnels_users2_idx` (`updated_by`),
  CONSTRAINT `fk_personnels_users1` FOREIGN KEY (`created_by`) REFERENCES `users` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fk_personnels_users2` FOREIGN KEY (`updated_by`) REFERENCES `users` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personnel`
--

LOCK TABLES `personnel` WRITE;
/*!40000 ALTER TABLE `personnel` DISABLE KEYS */;
/*!40000 ALTER TABLE `personnel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role_has_permissions`
--

DROP TABLE IF EXISTS `role_has_permissions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role_has_permissions` (
  `roles_id` int NOT NULL,
  `permissions_id` int NOT NULL,
  KEY `fk_role_has_permissions_roles1_idx` (`roles_id`),
  KEY `fk_role_has_permissions_permissions1_idx` (`permissions_id`),
  CONSTRAINT `fk_role_has_permissions_permissions1` FOREIGN KEY (`permissions_id`) REFERENCES `permissions` (`id`),
  CONSTRAINT `fk_role_has_permissions_roles1` FOREIGN KEY (`roles_id`) REFERENCES `roles` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role_has_permissions`
--

LOCK TABLES `role_has_permissions` WRITE;
/*!40000 ALTER TABLE `role_has_permissions` DISABLE KEYS */;
/*!40000 ALTER TABLE `role_has_permissions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(99) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Admin');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock_repair_history`
--

DROP TABLE IF EXISTS `stock_repair_history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stock_repair_history` (
  `id` int NOT NULL AUTO_INCREMENT,
  `reported_by` varchar(200) DEFAULT NULL,
  `issue_description` text,
  `repair_action` text,
  `repair_date` datetime DEFAULT NULL,
  `repaired_by` varchar(100) DEFAULT NULL,
  `cost` decimal(10,2) DEFAULT NULL,
  `other_details` text,
  `stocks_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_stock_repair_history_stocks1_idx` (`stocks_id`),
  CONSTRAINT `fk_stock_repair_history_stocks1` FOREIGN KEY (`stocks_id`) REFERENCES `stocks` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='	';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock_repair_history`
--

LOCK TABLES `stock_repair_history` WRITE;
/*!40000 ALTER TABLE `stock_repair_history` DISABLE KEYS */;
/*!40000 ALTER TABLE `stock_repair_history` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock_user_history`
--

DROP TABLE IF EXISTS `stock_user_history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stock_user_history` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user` varchar(150) DEFAULT NULL,
  `assigned_date` date DEFAULT NULL,
  `unassigned_date` date DEFAULT NULL,
  `branches_id` int NOT NULL,
  `stocks_id` int NOT NULL,
  `is_current_user` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `fk_stock_user_history_branches1_idx` (`branches_id`),
  KEY `fk_stock_user_history_stocks1_idx` (`stocks_id`),
  CONSTRAINT `fk_stock_user_history_branches1` FOREIGN KEY (`branches_id`) REFERENCES `branches` (`id`),
  CONSTRAINT `fk_stock_user_history_stocks1` FOREIGN KEY (`stocks_id`) REFERENCES `stocks` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock_user_history`
--

LOCK TABLES `stock_user_history` WRITE;
/*!40000 ALTER TABLE `stock_user_history` DISABLE KEYS */;
/*!40000 ALTER TABLE `stock_user_history` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stocks`
--

DROP TABLE IF EXISTS `stocks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stocks` (
  `id` int NOT NULL AUTO_INCREMENT,
  `item_id` int NOT NULL,
  `suppliers_id` int DEFAULT NULL,
  `serial_number` varchar(100) DEFAULT NULL,
  `model` varchar(100) DEFAULT NULL,
  `operating_system` varchar(45) DEFAULT NULL,
  `ram` varchar(45) DEFAULT NULL,
  `computer_name` varchar(100) DEFAULT NULL,
  `sophos_tamper` varchar(100) DEFAULT NULL,
  `date_acquired` date DEFAULT NULL,
  `unit_cost` decimal(10,2) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `remarks` text,
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `created_by` int DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL,
  `updated_by` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_stocks_items1_idx` (`item_id`),
  KEY `fk_stocks_suppliers1_idx` (`suppliers_id`),
  CONSTRAINT `fk_stocks_items1` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`),
  CONSTRAINT `fk_stocks_suppliers1` FOREIGN KEY (`suppliers_id`) REFERENCES `suppliers` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stocks`
--

LOCK TABLES `stocks` WRITE;
/*!40000 ALTER TABLE `stocks` DISABLE KEYS */;
/*!40000 ALTER TABLE `stocks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(99) NOT NULL,
  `address` varchar(99) DEFAULT NULL,
  `contact_info` varchar(99) DEFAULT NULL,
  `created_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_time` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (7,'Trinogo Traiding Corporation','900 Romualdes Streert Paco Manila','0916634952/0917600319','2025-05-19 02:40:55',NULL);
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unit_measurements`
--

DROP TABLE IF EXISTS `unit_measurements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `unit_measurements` (
  `id` int NOT NULL AUTO_INCREMENT,
  `abbreviation` varchar(10) NOT NULL,
  `name` varchar(99) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unit_measurements`
--

LOCK TABLES `unit_measurements` WRITE;
/*!40000 ALTER TABLE `unit_measurements` DISABLE KEYS */;
INSERT INTO `unit_measurements` VALUES (14,'Cm.','Centimeters'),(15,'Pcs','Pieces'),(16,'Rolls','Rolls');
/*!40000 ALTER TABLE `unit_measurements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `roles_id` int NOT NULL,
  `first_name` varchar(99) NOT NULL,
  `last_name` varchar(99) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(70) NOT NULL,
  `created_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_time` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_users_roles1_idx` (`roles_id`),
  CONSTRAINT `fk_users_roles1` FOREIGN KEY (`roles_id`) REFERENCES `roles` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,1,'Gener','Delos Reyes','gener','dae1b45bc5a59f1e2212dc33ba66e6ec54cb336174799d1a06bc5169','2017-07-23 05:10:11',NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `view_branch_stocks`
--

DROP TABLE IF EXISTS `view_branch_stocks`;
/*!50001 DROP VIEW IF EXISTS `view_branch_stocks`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_branch_stocks` AS SELECT 
 1 AS `branches_id`,
 1 AS `branch_name`,
 1 AS `stocks_id`,
 1 AS `item_id`,
 1 AS `item_code`,
 1 AS `item_name`,
 1 AS `categories_id`,
 1 AS `category_name`,
 1 AS `abbreviation`,
 1 AS `unit_measurements_name`,
 1 AS `suppliers_id`,
 1 AS `suppliers_name`,
 1 AS `suppliers_address`,
 1 AS `serial_number`,
 1 AS `model`,
 1 AS `operating_system`,
 1 AS `ram`,
 1 AS `computer_name`,
 1 AS `sophos_tamper`,
 1 AS `date_acquired`,
 1 AS `unit_cost`,
 1 AS `status`,
 1 AS `remarks`,
 1 AS `created_at`,
 1 AS `created_by`,
 1 AS `updated_at`,
 1 AS `updated_by`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_items`
--

DROP TABLE IF EXISTS `view_items`;
/*!50001 DROP VIEW IF EXISTS `view_items`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_items` AS SELECT 
 1 AS `id`,
 1 AS `categories_id`,
 1 AS `unit_measurements_id`,
 1 AS `name`,
 1 AS `code`,
 1 AS `category_name`,
 1 AS `unit_abbreviation`,
 1 AS `unit_name`,
 1 AS `created_by`,
 1 AS `created_time`,
 1 AS `updated_by`,
 1 AS `updated_time`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_stocks`
--

DROP TABLE IF EXISTS `view_stocks`;
/*!50001 DROP VIEW IF EXISTS `view_stocks`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_stocks` AS SELECT 
 1 AS `id`,
 1 AS `item_id`,
 1 AS `item_code`,
 1 AS `item_name`,
 1 AS `suppliers_id`,
 1 AS `serial_number`,
 1 AS `model`,
 1 AS `operating_system`,
 1 AS `ram`,
 1 AS `computer_name`,
 1 AS `sophos_tamper`,
 1 AS `date_acquired`,
 1 AS `unit_cost`,
 1 AS `status`,
 1 AS `created_at`,
 1 AS `created_by`,
 1 AS `updated_at`,
 1 AS `updated_by`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_users`
--

DROP TABLE IF EXISTS `view_users`;
/*!50001 DROP VIEW IF EXISTS `view_users`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_users` AS SELECT 
 1 AS `id`,
 1 AS `roles_id`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `username`,
 1 AS `password`,
 1 AS `created_time`,
 1 AS `updated_time`,
 1 AS `role_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `view_branch_stocks`
--

/*!50001 DROP VIEW IF EXISTS `view_branch_stocks`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`jo_monitoring`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `view_branch_stocks` AS select `branch_stocks`.`branches_id` AS `branches_id`,`branches`.`name` AS `branch_name`,`stocks`.`id` AS `stocks_id`,`items`.`id` AS `item_id`,`items`.`code` AS `item_code`,`items`.`name` AS `item_name`,`categories`.`id` AS `categories_id`,`categories`.`name` AS `category_name`,`unit_measurements`.`abbreviation` AS `abbreviation`,`unit_measurements`.`name` AS `unit_measurements_name`,`stocks`.`suppliers_id` AS `suppliers_id`,`suppliers`.`name` AS `suppliers_name`,`suppliers`.`address` AS `suppliers_address`,`stocks`.`serial_number` AS `serial_number`,`stocks`.`model` AS `model`,`stocks`.`operating_system` AS `operating_system`,`stocks`.`ram` AS `ram`,`stocks`.`computer_name` AS `computer_name`,`stocks`.`sophos_tamper` AS `sophos_tamper`,`stocks`.`date_acquired` AS `date_acquired`,`stocks`.`unit_cost` AS `unit_cost`,`stocks`.`status` AS `status`,`stocks`.`remarks` AS `remarks`,`stocks`.`created_at` AS `created_at`,`stocks`.`created_by` AS `created_by`,`stocks`.`updated_at` AS `updated_at`,`stocks`.`updated_by` AS `updated_by` from ((((((`branch_stocks` join `stocks` on((`stocks`.`id` = `branch_stocks`.`stocks_id`))) join `branches` on((`branches`.`id` = `branch_stocks`.`branches_id`))) join `suppliers` on((`suppliers`.`id` = `stocks`.`suppliers_id`))) join `items` on((`items`.`id` = `stocks`.`item_id`))) join `categories` on((`items`.`categories_id` = `categories`.`id`))) join `unit_measurements` on((`unit_measurements`.`id` = `items`.`unit_measurements_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_items`
--

/*!50001 DROP VIEW IF EXISTS `view_items`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`jo_monitoring`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `view_items` AS select `a`.`id` AS `id`,`a`.`categories_id` AS `categories_id`,`a`.`unit_measurements_id` AS `unit_measurements_id`,`a`.`name` AS `name`,`a`.`code` AS `code`,`b`.`name` AS `category_name`,`c`.`abbreviation` AS `unit_abbreviation`,`c`.`name` AS `unit_name`,`a`.`created_by` AS `created_by`,`a`.`created_time` AS `created_time`,`a`.`updated_by` AS `updated_by`,`a`.`updated_time` AS `updated_time` from ((`items` `a` join `categories` `b` on((`a`.`categories_id` = `b`.`id`))) join `unit_measurements` `c` on((`a`.`unit_measurements_id` = `c`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_stocks`
--

/*!50001 DROP VIEW IF EXISTS `view_stocks`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`jo_monitoring`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `view_stocks` AS select `stocks`.`id` AS `id`,`stocks`.`item_id` AS `item_id`,`items`.`code` AS `item_code`,`items`.`name` AS `item_name`,`stocks`.`suppliers_id` AS `suppliers_id`,`stocks`.`serial_number` AS `serial_number`,`stocks`.`model` AS `model`,`stocks`.`operating_system` AS `operating_system`,`stocks`.`ram` AS `ram`,`stocks`.`computer_name` AS `computer_name`,`stocks`.`sophos_tamper` AS `sophos_tamper`,`stocks`.`date_acquired` AS `date_acquired`,`stocks`.`unit_cost` AS `unit_cost`,`stocks`.`status` AS `status`,`stocks`.`created_at` AS `created_at`,`stocks`.`created_by` AS `created_by`,`stocks`.`updated_at` AS `updated_at`,`stocks`.`updated_by` AS `updated_by` from (`stocks` join `items` on((`stocks`.`item_id` = `items`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_users`
--

/*!50001 DROP VIEW IF EXISTS `view_users`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_users` AS select `a`.`id` AS `id`,`a`.`roles_id` AS `roles_id`,`a`.`first_name` AS `first_name`,`a`.`last_name` AS `last_name`,`a`.`username` AS `username`,`a`.`password` AS `password`,`a`.`created_time` AS `created_time`,`a`.`updated_time` AS `updated_time`,`b`.`name` AS `role_name` from (`users` `a` join `roles` `b` on((`a`.`roles_id` = `b`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-04 15:26:40
