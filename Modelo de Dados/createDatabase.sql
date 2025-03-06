-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema gestorevento
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema gestorevento
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `gestorevento` DEFAULT CHARACTER SET utf8mb3 ;
USE `gestorevento` ;

-- -----------------------------------------------------
-- Table `gestorevento`.`convidado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gestorevento`.`convidado` (
  `idConvidado` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `idade` INT NOT NULL,
  `sexo` VARCHAR(2) NOT NULL,
  `numConvite` INT NOT NULL,
  PRIMARY KEY (`idConvidado`),
  UNIQUE INDEX `numConvite_UNIQUE` (`numConvite` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `gestorevento`.`evento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gestorevento`.`evento` (
  `idEvento` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `dt_hora` DATETIME NOT NULL,
  `local` VARCHAR(255) NOT NULL,
  `descricao` VARCHAR(255) NULL DEFAULT NULL,
  `categoria` VARCHAR(100) NULL DEFAULT NULL,
  `duracao` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`idEvento`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `gestorevento`.`convidadoevento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gestorevento`.`convidadoevento` (
  `idConvidado` INT NOT NULL,
  `idEvento` INT NOT NULL,
  `status` ENUM('PRESENTE', 'AUSENTE', 'N/A') NULL DEFAULT 'N/A',
  PRIMARY KEY (`idConvidado`, `idEvento`),
  INDEX `fk_Convidado_has_Evento_Evento1_idx` (`idEvento` ASC) VISIBLE,
  INDEX `fk_Convidado_has_Evento_Convidado_idx` (`idConvidado` ASC) VISIBLE,
  CONSTRAINT `fk_Convidado_has_Evento_Convidado`
    FOREIGN KEY (`idConvidado`)
    REFERENCES `gestorevento`.`convidado` (`idConvidado`),
  CONSTRAINT `fk_Convidado_has_Evento_Evento1`
    FOREIGN KEY (`idEvento`)
    REFERENCES `gestorevento`.`evento` (`idEvento`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
